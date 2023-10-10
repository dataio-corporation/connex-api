// Cake settings
var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

// Build settings
var solutionFolder = ".";
var outputFolder = "./artifacts";
var connexGraphqlProject = System.IO.Path.Combine(solutionFolder, @"DataIO.ConneX.Api.GraphQL\DataIO.ConneX.Api.GraphQL.csproj");
var connexMqttProject = System.IO.Path.Combine(solutionFolder, @"DataIO.ConneX.Api.Mqtt\DataIO.ConneX.Api.Mqtt.csproj");
var helpOutputFolder = System.IO.Path.Combine(outputFolder, "help");
var helpLocation = "../docs/help";

var cleanTask = Task("Clean")
  .Does(() => {
    CleanDirectory(outputFolder);
    DotNetClean(solutionFolder, new DotNetCleanSettings()
    {
      Configuration = configuration
    });
  });

var restoreTask = Task("Restore")
  .Does(() =>
  {
    DotNetRestore(solutionFolder);
  });

var buildHelpTask = Task("BuildHelp")
  .Does(() => {
    if (!System.IO.Directory.Exists(helpOutputFolder))
    {
       System.IO.Directory.CreateDirectory(helpOutputFolder);
    }

    StartProcess("docfx", $"build {System.IO.Path.Combine(helpLocation, "docfx.json")} -o {helpOutputFolder}");
  });

var buildTask = Task("Build")
  .IsDependentOn(cleanTask)
  .IsDependentOn(restoreTask)
  .IsDependentOn(buildHelpTask)
  .Does(() => {
    // ConneX API solution
    DotNetBuild(solutionFolder, new DotNetBuildSettings{
      NoRestore = true,
      Configuration = configuration,
      MSBuildSettings = new DotNetMSBuildSettings()
      {
        TreatAllWarningsAs = MSBuildTreatAllWarningsAs.Error
      }
    });
  });

var nugetPack = Task("NugetPack")
  .IsDependentOn(buildTask)
  .Does(() => {

    var packSettings = new DotNetPackSettings {
        Configuration = configuration,
        NoBuild = true,
        NoRestore = true,
        OutputDirectory = outputFolder
    };

    // ConneX GraphQL nuget package
    DotNetPack(connexGraphqlProject, packSettings);

    // ConneX MQTT nuget package
    DotNetPack(connexMqttProject, packSettings);
  });

  // Set default task to run
Task("Default")
  .IsDependentOn(buildTask);

RunTarget(target);
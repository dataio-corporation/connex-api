# DMS
Below, you will find the MQTT events that are published/subscribed relating to DMS:


Message                           | Description
----------------------------------|-----------------------------------------------
[Begin Download](#begin-download) | Event published when DMS begins a job download.
[End Download](#end-download)     | Event published when DMS completes a job download.

## Begin Download
---
**Topic:** `dms/jobs/begindownload/{hostname}/{jobname}`

Event published when DMS begins a job download.

Level    | Description
---------|-----------------------------------------------
hostname | The hostname of the PC where DMS is running.
jobname  | The name of the job.

### Fields
Name                   | Description
-----------------------|------------------------------
DownloadSize (`ulong`) | The size of the job in bytes.

## End Download
---
**Topic:** `dms/jobs/enddownload/{hostname}/{jobname}`

Event published when DMS completes a job download.

Level    | Description
---------|-----------------------------------------------
hostname | The hostname of the PC where DMS is running.
jobname  | The name of the job.

### Fields
Name             | Description
-----------------|-------------------------------------------
Success (`bool`) | Whether or not the job completed downloading to the programmer(s).
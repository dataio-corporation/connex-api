namespace DataIO.ConneX.Api.Mqtt.Messages.Common
{
    /// <summary>
    /// Enum representing a handler error code value assigned to rejected devices or the final status value reported by the handler for passed devices.
    /// </summary>
    public enum PsvErrorCode
    {
        /// <summary>
        /// Location holds a device being tested
        /// </summary>
        DeviceUnderTest = 1,
        
        /// <summary>
        /// Location holds a good and passed device
        /// </summary>
        DevicePassed = 2,

        /// <summary>
        /// Device programming error
        /// </summary>
        DeviceProgrammingError = 3,
        
        /// <summary>
        /// Location holds a device not yet programmed
        /// </summary>
        DeviceNotYetProgrammed = 5,
        
        /// <summary>
        /// Location holds a device being programmed
        /// </summary>
        DeviceProgramming = 6,
        
        /// <summary>
        /// Socket might be missing at this location
        /// </summary>
        SocketMissing = 7,
        
        /// <summary>
        /// Too many successive errors at this socket
        /// </summary>
        SocketErrorThresholdExceeded = 9,
        
        /// <summary>
        /// Socket intentionally not loaded
        /// </summary>
        SocketNotLoaded = 10,
        
        /// <summary>
        /// Unknown error occurred
        /// </summary>
        UnknownError = 11,
        
        /// <summary>
        ///	Recurrent Empty Socket Test (REST) error; the device is not programmed
        /// </summary>
        RestError = 12,
        
        /// <summary>
        /// Device laser marking occurred
        /// </summary>
        DeviceLaserMarked = 14,
        
        /// <summary>
        /// Device laser marking error
        /// </summary>
        DeviceLaserMarkingError = 15,
        
        /// <summary>
        /// Device continuity error
        /// </summary>
        DeviceContinuityError = 17,
        
        /// <summary>
        /// Failed empty socket test (EST)
        /// </summary>
        EstFailure = 20,
        
        /// <summary>
        /// 3D error before programming
        /// </summary>
        PreProgramming3DError = 21,
        
        /// <summary>
        /// Empty Socket Test (EST) is running
        /// </summary>
        RunningEst = 22,
        
        /// <summary>
        /// Wrong adapter
        /// </summary>
        WrongAdapter = 23,
        
        /// <summary>
        /// Bad job
        /// </summary>
        BadJob = 24,
        
        /// <summary>
        /// Device is shorted
        /// </summary>
        DeviceShorted = 25,
        
        /// <summary>
        /// Device position inspection error
        /// </summary>
        DevicePositionInspectionError = 200,
        
        /// <summary>
        /// Device 3D inspection error
        /// </summary>
        Device3dInspectionError = 201,
        
        /// <summary>
        /// Hardware failure
        /// </summary>
        HardwareFailure = 255,
        
        /// <summary>
        /// 2D inspection failure, unexpected device in pocket
        /// </summary>
        TwoDInspectionFailureUnexpectedDevice = 901,
        
        /// <summary>
        /// 2D inspection failure, device not detected
        /// </summary>
        TwoDInspectionFailureDeviceNotDetected = 902,
        
        /// <summary>
        /// 2D inspection failure, device detected but failed inspection
        /// </summary>
        TwoDInspectionFailureDeviceFailedInspection = 903,
        
        /// <summary>
        /// 2D inspection timeout failure
        /// </summary>
        TwoDInspectionFailureTimeout = 904,
        
        /// <summary>
        /// Tape out error
        /// </summary>
        TapeOutError = 910,
        
        /// <summary>
        /// No adapter installed
        /// </summary>
        NoAdapterInstalled = 1044
    }
}

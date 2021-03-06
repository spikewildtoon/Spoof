﻿// Decompiled with JetBrains decompiler
// Type: TSN.Native.Enums.NtStatus
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

namespace TSN.Native.Enums
{
  public enum NtStatus : uint
  {
    Success = 0,
    Wait0 = 0,
    Wait1 = 1,
    Wait2 = 2,
    Wait3 = 3,
    Wait63 = 63,
    Abandoned = 128,
    AbandonedWait0 = 128,
    AbandonedWait1 = 129,
    AbandonedWait2 = 130,
    AbandonedWait3 = 131,
    AbandonedWait63 = 191,
    UserApc = 192,
    KernelApc = 256,
    Alerted = 257,
    Timeout = 258,
    Pending = 259,
    Reparse = 260,
    MoreEntries = 261,
    NotAllAssigned = 262,
    SomeNotMapped = 263,
    OpLockBreakInProgress = 264,
    VolumeMounted = 265,
    RxActCommitted = 266,
    NotifyCleanup = 267,
    NotifyEnumDir = 268,
    NoQuotasForAccount = 269,
    PrimaryTransportConnectFailed = 270,
    PageFaultTransition = 272,
    PageFaultDemandZero = 273,
    PageFaultCopyOnWrite = 274,
    PageFaultGuardPage = 275,
    PageFaultPagingFile = 276,
    CrashDump = 278,
    ReparseObject = 280,
    NothingToTerminate = 290,
    ProcessNotInJob = 291,
    ProcessInJob = 292,
    ProcessCloned = 297,
    FileLockedWithOnlyReaders = 298,
    FileLockedWithWriters = 299,
    Informational = 1073741824,
    ObjectNameExists = 1073741824,
    ThreadWasSuspended = 1073741825,
    WorkingSetLimitRange = 1073741826,
    ImageNotAtBase = 1073741827,
    RegistryRecovered = 1073741833,
    Warning = 2147483648,
    GuardPageViolation = 2147483649,
    DatatypeMisalignment = 2147483650,
    Breakpoint = 2147483651,
    SingleStep = 2147483652,
    BufferOverflow = 2147483653,
    NoMoreFiles = 2147483654,
    HandlesClosed = 2147483658,
    PartialCopy = 2147483661,
    DeviceBusy = 2147483665,
    InvalidEaName = 2147483667,
    EaListInconsistent = 2147483668,
    NoMoreEntries = 2147483674,
    LongJump = 2147483686,
    DllMightBeInsecure = 2147483691,
    Error = 3221225472,
    Unsuccessful = 3221225473,
    NotImplemented = 3221225474,
    InvalidInfoClass = 3221225475,
    InfoLengthMismatch = 3221225476,
    AccessViolation = 3221225477,
    InPageError = 3221225478,
    PagefileQuota = 3221225479,
    InvalidHandle = 3221225480,
    BadInitialStack = 3221225481,
    BadInitialPc = 3221225482,
    InvalidCid = 3221225483,
    TimerNotCanceled = 3221225484,
    InvalidParameter = 3221225485,
    NoSuchDevice = 3221225486,
    NoSuchFile = 3221225487,
    InvalidDeviceRequest = 3221225488,
    EndOfFile = 3221225489,
    WrongVolume = 3221225490,
    NoMediaInDevice = 3221225491,
    NoMemory = 3221225495,
    NotMappedView = 3221225497,
    UnableToFreeVm = 3221225498,
    UnableToDeleteSection = 3221225499,
    IllegalInstruction = 3221225501,
    AlreadyCommitted = 3221225505,
    AccessDenied = 3221225506,
    BufferTooSmall = 3221225507,
    ObjectTypeMismatch = 3221225508,
    NonContinuableException = 3221225509,
    BadStack = 3221225512,
    NotLocked = 3221225514,
    NotCommitted = 3221225517,
    InvalidParameterMix = 3221225520,
    ObjectNameInvalid = 3221225523,
    ObjectNameNotFound = 3221225524,
    ObjectNameCollision = 3221225525,
    ObjectPathInvalid = 3221225529,
    ObjectPathNotFound = 3221225530,
    ObjectPathSyntaxBad = 3221225531,
    DataOverrun = 3221225532,
    DataLate = 3221225533,
    DataError = 3221225534,
    CrcError = 3221225535,
    SectionTooBig = 3221225536,
    PortConnectionRefused = 3221225537,
    InvalidPortHandle = 3221225538,
    SharingViolation = 3221225539,
    QuotaExceeded = 3221225540,
    InvalidPageProtection = 3221225541,
    MutantNotOwned = 3221225542,
    SemaphoreLimitExceeded = 3221225543,
    PortAlreadySet = 3221225544,
    SectionNotImage = 3221225545,
    SuspendCountExceeded = 3221225546,
    ThreadIsTerminating = 3221225547,
    BadWorkingSetLimit = 3221225548,
    IncompatibleFileMap = 3221225549,
    SectionProtection = 3221225550,
    EasNotSupported = 3221225551,
    EaTooLarge = 3221225552,
    NonExistentEaEntry = 3221225553,
    NoEasOnFile = 3221225554,
    EaCorruptError = 3221225555,
    FileLockConflict = 3221225556,
    LockNotGranted = 3221225557,
    DeletePending = 3221225558,
    CtlFileNotSupported = 3221225559,
    UnknownRevision = 3221225560,
    RevisionMismatch = 3221225561,
    InvalidOwner = 3221225562,
    InvalidPrimaryGroup = 3221225563,
    NoImpersonationToken = 3221225564,
    CantDisableMandatory = 3221225565,
    NoLogonServers = 3221225566,
    NoSuchLogonSession = 3221225567,
    NoSuchPrivilege = 3221225568,
    PrivilegeNotHeld = 3221225569,
    InvalidAccountName = 3221225570,
    UserExists = 3221225571,
    NoSuchUser = 3221225572,
    GroupExists = 3221225573,
    NoSuchGroup = 3221225574,
    MemberInGroup = 3221225575,
    MemberNotInGroup = 3221225576,
    LastAdmin = 3221225577,
    WrongPassword = 3221225578,
    IllFormedPassword = 3221225579,
    PasswordRestriction = 3221225580,
    LogonFailure = 3221225581,
    AccountRestriction = 3221225582,
    InvalidLogonHours = 3221225583,
    InvalidWorkstation = 3221225584,
    PasswordExpired = 3221225585,
    AccountDisabled = 3221225586,
    NoneMapped = 3221225587,
    TooManyLuidsRequested = 3221225588,
    LuidsExhausted = 3221225589,
    InvalidSubAuthority = 3221225590,
    InvalidAcl = 3221225591,
    InvalidSid = 3221225592,
    InvalidSecurityDescr = 3221225593,
    ProcedureNotFound = 3221225594,
    InvalidImageFormat = 3221225595,
    NoToken = 3221225596,
    BadInheritanceAcl = 3221225597,
    RangeNotLocked = 3221225598,
    DiskFull = 3221225599,
    ServerDisabled = 3221225600,
    ServerNotDisabled = 3221225601,
    TooManyGuidsRequested = 3221225602,
    GuidsExhausted = 3221225603,
    InvalidIdAuthority = 3221225604,
    AgentsExhausted = 3221225605,
    InvalidVolumeLabel = 3221225606,
    SectionNotExtended = 3221225607,
    NotMappedData = 3221225608,
    ResourceDataNotFound = 3221225609,
    ResourceTypeNotFound = 3221225610,
    ResourceNameNotFound = 3221225611,
    ArrayBoundsExceeded = 3221225612,
    FloatDenormalOperand = 3221225613,
    FloatDivideByZero = 3221225614,
    FloatInexactResult = 3221225615,
    FloatInvalidOperation = 3221225616,
    FloatOverflow = 3221225617,
    FloatStackCheck = 3221225618,
    FloatUnderflow = 3221225619,
    IntegerDivideByZero = 3221225620,
    IntegerOverflow = 3221225621,
    PrivilegedInstruction = 3221225622,
    TooManyPagingFiles = 3221225623,
    FileInvalid = 3221225624,
    InstanceNotAvailable = 3221225643,
    PipeNotAvailable = 3221225644,
    InvalidPipeState = 3221225645,
    PipeBusy = 3221225646,
    IllegalFunction = 3221225647,
    PipeDisconnected = 3221225648,
    PipeClosing = 3221225649,
    PipeConnected = 3221225650,
    PipeListening = 3221225651,
    InvalidReadMode = 3221225652,
    IoTimeout = 3221225653,
    FileForcedClosed = 3221225654,
    ProfilingNotStarted = 3221225655,
    ProfilingNotStopped = 3221225656,
    NotSameDevice = 3221225684,
    FileRenamed = 3221225685,
    CantWait = 3221225688,
    PipeEmpty = 3221225689,
    CantTerminateSelf = 3221225691,
    InternalError = 3221225701,
    InvalidParameter1 = 3221225711,
    InvalidParameter2 = 3221225712,
    InvalidParameter3 = 3221225713,
    InvalidParameter4 = 3221225714,
    InvalidParameter5 = 3221225715,
    InvalidParameter6 = 3221225716,
    InvalidParameter7 = 3221225717,
    InvalidParameter8 = 3221225718,
    InvalidParameter9 = 3221225719,
    InvalidParameter10 = 3221225720,
    InvalidParameter11 = 3221225721,
    InvalidParameter12 = 3221225722,
    MappedFileSizeZero = 3221225758,
    TooManyOpenedFiles = 3221225759,
    Canceled = 3221225760,
    CannotDelete = 3221225761,
    InvalidComputerName = 3221225762,
    FileDeleted = 3221225763,
    SpecialAccount = 3221225764,
    SpecialGroup = 3221225765,
    SpecialUser = 3221225766,
    MembersPrimaryGroup = 3221225767,
    FileClosed = 3221225768,
    TooManyThreads = 3221225769,
    ThreadNotInProcess = 3221225770,
    TokenAlreadyInUse = 3221225771,
    PagefileQuotaExceeded = 3221225772,
    CommitmentLimit = 3221225773,
    InvalidImageLeFormat = 3221225774,
    InvalidImageNotMz = 3221225775,
    InvalidImageProtect = 3221225776,
    InvalidImageWin16 = 3221225777,
    LogonServer = 3221225778,
    DifferenceAtDc = 3221225779,
    SynchronizationRequired = 3221225780,
    DllNotFound = 3221225781,
    IoPrivilegeFailed = 3221225783,
    OrdinalNotFound = 3221225784,
    EntryPointNotFound = 3221225785,
    ControlCExit = 3221225786,
    PortNotSet = 3221226323,
    DebuggerInactive = 3221226324,
    CallbackBypass = 3221226755,
    PortClosed = 3221227264,
    MessageLost = 3221227265,
    InvalidMessage = 3221227266,
    RequestCanceled = 3221227267,
    RecursiveDispatch = 3221227268,
    LpcReceiveBufferExpected = 3221227269,
    LpcInvalidConnectionUsage = 3221227270,
    LpcRequestsNotAllowed = 3221227271,
    ResourceInUse = 3221227272,
    ProcessIsProtected = 3221227282,
    VolumeDirty = 3221227526,
    FileCheckedOut = 3221227777,
    CheckOutRequired = 3221227778,
    BadFileType = 3221227779,
    FileTooLarge = 3221227780,
    FormsAuthRequired = 3221227781,
    VirusInfected = 3221227782,
    VirusDeleted = 3221227783,
    TransactionalConflict = 3222863873,
    InvalidTransaction = 3222863874,
    TransactionNotActive = 3222863875,
    TmInitializationFailed = 3222863876,
    RmNotActive = 3222863877,
    RmMetadataCorrupt = 3222863878,
    TransactionNotJoined = 3222863879,
    DirectoryNotRm = 3222863880,
    CouldNotResizeLog = 3222863881,
    TransactionsUnsupportedRemote = 3222863882,
    LogResizeInvalidSize = 3222863883,
    RemoteFileVersionMismatch = 3222863884,
    CrmProtocolAlreadyExists = 3222863887,
    TransactionPropagationFailed = 3222863888,
    CrmProtocolNotFound = 3222863889,
    TransactionSuperiorExists = 3222863890,
    TransactionRequestNotValid = 3222863891,
    TransactionNotRequested = 3222863892,
    TransactionAlreadyAborted = 3222863893,
    TransactionAlreadyCommitted = 3222863894,
    TransactionInvalidMarshallBuffer = 3222863895,
    CurrentTransactionNotValid = 3222863896,
    LogGrowthFailed = 3222863897,
    ObjectNoLongerExists = 3222863905,
    StreamMiniversionNotFound = 3222863906,
    StreamMiniversionNotValid = 3222863907,
    MiniversionInaccessibleFromSpecifiedTransaction = 3222863908,
    CantOpenMiniversionWithModifyIntent = 3222863909,
    CantCreateMoreStreamMiniversions = 3222863910,
    HandleNoLongerValid = 3222863912,
    NoTxfMetadata = 3222863913,
    LogCorruptionDetected = 3222863920,
    CantRecoverWithHandleOpen = 3222863921,
    RmDisconnected = 3222863922,
    EnlistmentNotSuperior = 3222863923,
    RecoveryNotNeeded = 3222863924,
    RmAlreadyStarted = 3222863925,
    FileIdentityNotPersistent = 3222863926,
    CantBreakTransactionalDependency = 3222863927,
    CantCrossRmBoundary = 3222863928,
    TxfDirNotEmpty = 3222863929,
    IndoubtTransactionsExist = 3222863930,
    TmVolatile = 3222863931,
    RollbackTimerExpired = 3222863932,
    TxfAttributeCorrupt = 3222863933,
    EfsNotAllowedInTransaction = 3222863934,
    TransactionalOpenNotAllowed = 3222863935,
    TransactedMappingUnsupportedRemote = 3222863936,
    TxfMetadataAlreadyPresent = 3222863937,
    TransactionScopeCallbacksNotSet = 3222863938,
    TransactionRequiredPromotion = 3222863939,
    CannotExecuteFileInTransaction = 3222863940,
    TransactionsNotFrozen = 3222863941,
    MaximumNtStatus = 4294967295,
  }
}

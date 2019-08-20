﻿using System;
using LibHac.Common;
using LibHac.Fs;
using LibHac.Fs.Save;

namespace LibHac.FsService.Creators
{
    public interface ISaveDataFileSystemCreator
    {
        Result CreateFile(out IFile file, IFileSystem sourceFileSystem, ulong saveDataId, OpenMode openMode);

        Result Create(out IFileSystem fileSystem, out ISaveDataExtraDataAccessor extraDataAccessor,
            IFileSystem sourceFileSystem, ulong saveDataId, bool allowDirectorySaveData, bool useDeviceUniqueMac,
            SaveDataType type, ITimeStampGenerator timeStampGenerator);

        Result SetSdCardEncryptionSeed(ReadOnlySpan<byte> seed);
    }
}

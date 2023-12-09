﻿using ByteTest.Dtos;

namespace ByteTest.SerialHelpers;

public interface ISerializeHelper
{
    string Name();
    byte[] Serialize(Organization data);

    Organization? Deserialize(byte[] buffer);
}
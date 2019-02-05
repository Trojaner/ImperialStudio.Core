﻿using NetStack.Serialization;

namespace ImperialStudio.Core.Api.Entities
{
    public interface IEntityState
    {
        void Read(BitBuffer buffer);
        void ReadDelta(BitBuffer bitBuffer);


        void Write(BitBuffer buffer);
        void WriteDelta(BitBuffer buffer, BitBuffer previousState);
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Interfaces
{
    public interface IPlay
    {
        void Play(AItem toy, APet pet);   
    }
}

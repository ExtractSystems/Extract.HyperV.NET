using System;

namespace HyperV
{
    ///<summary>Defines the type of virtual hard disk.</summary>
    public enum VirtualHardDiskType : UInt16
    {
        Unknown = 0,
        ///<summary>Space for fixed virtual hard disks is first allocated when the file is created.</summary>
        FixedSize = 2,

        ///<summary>Space for dynamically expanding virtual hard disks is allocated on demand.</summary>
        DynamicallyExpanding = 3,

        // Uses a base(template) hard disk 
        Differencing = 4
    }
}
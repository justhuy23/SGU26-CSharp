
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly Bai1
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 19 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 31 30 2E 30 01 00 54 0E   // ersion=v10.0..T.
                                                                                                              14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61   // .FrameworkDispla
                                                                                                              79 4E 61 6D 65 09 2E 4E 45 54 20 31 30 2E 30 )    // yName..NET 10.0
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 04 42 61 69 31 00 00 )                      // ...Bai1..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 2E 31 2E 30 2E 30 2B 63 34 63 34 37 62 62   // ...1.0.0+c4c47bb
                                                                                                                   66 63 65 32 66 38 30 30 32 37 63 39 36 31 63 66   // fce2f80027c961cf
                                                                                                                   32 35 64 36 63 39 66 65 33 36 34 35 37 37 37 37   // 25d6c9fe36457777
                                                                                                                   65 00 00 )                                        // e..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 04 42 61 69 31 00 00 )                      // ...Bai1..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 04 42 61 69 31 00 00 )                      // ...Bai1..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Bai1.dll
// MVID: {3A0571A8-0ECD-4081-B944-9D16F1D0F241}
.custom instance void [System.Runtime]System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06C30000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Bai1.NhapXuatHoTen
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       36 (0x24)
    .maxstack  2
    .locals init (string V_0)
    IL_0000:  nop
    IL_0001:  ldstr      "Moi ban nhap ho ten: "
    IL_0006:  call       void [System.Console]System.Console::Write(string)
    IL_000b:  nop
    IL_000c:  call       string [System.Console]System.Console::ReadLine()
    IL_0011:  stloc.0
    IL_0012:  ldstr      "Ho ten cua ban la: "
    IL_0017:  ldloc.0
    IL_0018:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_001d:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0022:  nop
    IL_0023:  ret
  } // end of method NhapXuatHoTen::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method NhapXuatHoTen::.ctor

} // end of class Bai1.NhapXuatHoTen


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file Bai1.res

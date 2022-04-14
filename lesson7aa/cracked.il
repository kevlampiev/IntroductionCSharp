
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly lesson7aa
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 09 6C 65 73 73 6F 6E 37 61 61 00 00 )       // ...lesson7aa..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 09 6C 65 73 73 6F 6E 37 61 61 00 00 )       // ...lesson7aa..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 32 00 00 )                            //  2022..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 63 32 39 39 35 66 61 38 2D 33 61 66 38   // ..$c2995fa8-3af8
                                                                                                  2D 34 36 62 30 2D 38 33 30 33 2D 31 36 34 64 33   // -46b0-8303-164d3
                                                                                                  34 35 65 31 66 31 36 00 00 )                      // 45e1f16..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module lesson7aa.exe
// MVID: {67924A5F-1EB4-4ADE-89BB-C6A30D6D1015}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x07050000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit lesson7.Lohotron
       extends [mscorlib]System.Object
{
  .field private int32 _winningBid
  .field private int32 _bidAmount
  .field private int32 '<Remain>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private int32 '<Bet>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname instance int32 
          get_Remain() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 lesson7.Lohotron::'<Remain>k__BackingField'
    IL_0006:  ret
  } // end of method Lohotron::get_Remain

  .method public hidebysig specialname instance void 
          set_Remain(int32 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Размер кода:       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      int32 lesson7.Lohotron::'<Remain>k__BackingField'
    IL_0007:  ret
  } // end of method Lohotron::set_Remain

  .method public hidebysig specialname instance int32 
          get_Bet() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 lesson7.Lohotron::'<Bet>k__BackingField'
    IL_0006:  ret
  } // end of method Lohotron::get_Bet

  .method public hidebysig specialname instance void 
          set_Bet(int32 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Размер кода:       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      int32 lesson7.Lohotron::'<Bet>k__BackingField'
    IL_0007:  ret
  } // end of method Lohotron::set_Bet

  .method public hidebysig specialname instance int32 
          get_WinningBid() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 lesson7.Lohotron::_winningBid
    IL_0006:  ret
  } // end of method Lohotron::get_WinningBid

  .method public hidebysig specialname instance int32 
          get_BidAmount() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 lesson7.Lohotron::_bidAmount
    IL_0006:  ret
  } // end of method Lohotron::get_BidAmount

  .method public hidebysig specialname instance bool 
          get_ReadyToPlay() cil managed
  {
    // Размер кода:       39 (0x27)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance int32 lesson7.Lohotron::get_Remain()
    IL_0006:  ldarg.0
    IL_0007:  call       instance int32 lesson7.Lohotron::get_BidAmount()
    IL_000c:  blt.s      IL_0025

    IL_000e:  ldarg.0
    IL_000f:  call       instance int32 lesson7.Lohotron::get_Bet()
    IL_0014:  ldc.i4.0
    IL_0015:  blt.s      IL_0025

    IL_0017:  ldarg.0
    IL_0018:  call       instance int32 lesson7.Lohotron::get_Bet()
    IL_001d:  ldc.i4.s   9
    IL_001f:  cgt
    IL_0021:  ldc.i4.0
    IL_0022:  ceq
    IL_0024:  ret

    IL_0025:  ldc.i4.0
    IL_0026:  ret
  } // end of method Lohotron::get_ReadyToPlay

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 bidAmount) cil managed
  {
    // Размер кода:       54 (0x36)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  ldc.i4.s   10
    IL_000a:  call       int32 [mscorlib]System.Math::Max(int32,
                                                          int32)
    IL_000f:  stfld      int32 lesson7.Lohotron::_bidAmount
    IL_0014:  ldarg.0
    IL_0015:  ldc.i4.m1
    IL_0016:  stfld      int32 lesson7.Lohotron::_winningBid
    IL_001b:  ldstr      bytearray (11 04 1E 04 1B 04 2C 04 28 04 10 04 2F 04 20 00   // ......,.(.../. .
                                    1B 04 1E 04 22 04 15 04 20 04 15 04 2F 04 2E 00   // ...."... .../...
                                    0A 00 12 04 20 00 3A 04 30 04 36 04 34 04 3E 04   // .... .:.0.6.4.>.
                                    3C 04 20 00 42 04 43 04 40 04 35 04 20 00 40 04   // <. .B.C.@.5. .@.
                                    30 04 37 04 4B 04 33 04 40 04 4B 04 32 04 30 04   // 0.7.K.3.@.K.2.0.
                                    35 04 3C 04 20 00 7B 00 30 00 7D 00 20 00 40 04   // 5.<. .{.0.}. .@.
                                    43 04 31 04 2E 00 20 00 30 00 30 00 20 00 3A 04   // C.1... .0.0. .:.
                                    3E 04 3F 04 2E 00 21 00 21 00 21 00 21 00 )       // >.?...!.!.!.!.
    IL_0020:  ldarg.0
    IL_0021:  call       instance int32 lesson7.Lohotron::get_BidAmount()
    IL_0026:  box        [mscorlib]System.Int32
    IL_002b:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0030:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0035:  ret
  } // end of method Lohotron::.ctor

  .method public hidebysig instance void 
          GetMoney() cil managed
  {
    // Размер кода:       50 (0x32)
    .maxstack  3
    .locals init ([0] int32 m)
    IL_0000:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    41 04 43 04 3C 04 3C 04 43 04 20 00 3F 04 3E 04   // A.C.<.<.C. .?.>.
                                    3F 04 3E 04 3B 04 3D 04 35 04 3D 04 38 04 4F 04   // ?.>.;.=.5.=.8.O.
                                    20 00 41 04 47 04 35 04 42 04 30 04 3A 00 20 00 ) //  .A.G.5.B.0.:. .
    IL_0005:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000a:  call       string [mscorlib]System.Console::ReadLine()
    IL_000f:  ldloca.s   m
    IL_0011:  call       bool [mscorlib]System.Int32::TryParse(string,
                                                               int32&)
    IL_0016:  brfalse.s  IL_0027

    IL_0018:  ldarg.0
    IL_0019:  ldarg.0
    IL_001a:  call       instance int32 lesson7.Lohotron::get_Remain()
    IL_001f:  ldloc.0
    IL_0020:  add
    IL_0021:  call       instance void lesson7.Lohotron::set_Remain(int32)
    IL_0026:  ret

    IL_0027:  ldstr      bytearray (32 04 32 04 35 04 34 04 35 04 3D 04 30 04 20 00   // 2.2.5.4.5.=.0. .
                                    3D 04 35 04 3A 04 3E 04 40 04 40 04 35 04 3A 04   // =.5.:.>.@.@.5.:.
                                    42 04 3D 04 30 04 4F 04 20 00 41 04 43 04 3C 04   // B.=.0.O. .A.C.<.
                                    3C 04 30 04 )                                     // <.0.
    IL_002c:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0031:  ret
  } // end of method Lohotron::GetMoney

  .method public hidebysig instance void 
          GetBet() cil managed
  {
    // Размер кода:       73 (0x49)
    .maxstack  2
    .locals init ([0] int32 bet)
    IL_0000:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    63 00 32 04 3E 04 35 04 20 00 47 04 38 04 41 04   // c.2.>.5. .G.8.A.
                                    3B 04 3E 04 20 00 43 04 34 04 30 04 47 04 38 04   // ;.>. .C.4.0.G.8.
                                    20 00 28 00 30 00 2D 00 39 00 29 00 3A 00 20 00 ) //  .(.0.-.9.).:. .
    IL_0005:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000a:  call       string [mscorlib]System.Console::ReadLine()
    IL_000f:  ldloca.s   bet
    IL_0011:  call       bool [mscorlib]System.Int32::TryParse(string,
                                                               int32&)
    IL_0016:  brfalse.s  IL_003e

    IL_0018:  ldloc.0
    IL_0019:  ldc.i4.0
    IL_001a:  blt.s      IL_0033

    IL_001c:  ldloc.0
    IL_001d:  ldc.i4.s   10
    IL_001f:  bge.s      IL_0033

    IL_0021:  ldstr      bytearray (21 04 42 04 30 04 32 04 3A 04 30 04 20 00 3F 04   // !.B.0.2.:.0. .?.
                                    40 04 38 04 3D 04 4F 04 42 04 30 04 )             // @.8.=.O.B.0.
    IL_0026:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_002b:  ldarg.0
    IL_002c:  ldloc.0
    IL_002d:  call       instance void lesson7.Lohotron::set_Bet(int32)
    IL_0032:  ret

    IL_0033:  ldstr      bytearray (1D 04 35 04 3A 04 3E 04 40 04 40 04 35 04 3A 04   // ..5.:.>.@.@.5.:.
                                    42 04 3D 04 30 04 4F 04 20 00 41 04 42 04 30 04   // B.=.0.O. .A.B.0.
                                    32 04 3A 04 30 04 )                               // 2.:.0.
    IL_0038:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_003d:  ret

    IL_003e:  ldstr      bytearray (12 04 32 04 35 04 34 04 35 04 3D 04 3E 04 35 04   // ..2.5.4.5.=.>.5.
                                    20 00 45 04 3D 04 30 04 47 04 35 04 3D 04 38 04   //  .E.=.0.G.5.=.8.
                                    35 04 20 00 3D 04 35 04 20 00 4F 04 32 04 3B 04   // 5. .=.5. .O.2.;.
                                    4F 04 35 04 42 04 41 04 4F 04 20 00 47 04 38 04   // O.5.B.A.O. .G.8.
                                    41 04 3B 04 3E 04 3C 04 )                         // A.;.>.<.
    IL_0043:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0048:  ret
  } // end of method Lohotron::GetBet

  .method public hidebysig instance void 
          ShowRemain() cil managed
  {
    // Размер кода:       27 (0x1b)
    .maxstack  8
    IL_0000:  ldstr      bytearray (1E 04 41 04 42 04 30 04 42 04 3E 04 3A 04 20 00   // ..A.B.0.B.>.:. .
                                    32 04 30 04 48 04 35 04 33 04 3E 04 20 00 41 04   // 2.0.H.5.3.>. .A.
                                    47 04 35 04 42 04 30 04 20 00 41 04 3E 04 41 04   // G.5.B.0. .A.>.A.
                                    42 04 30 04 32 04 3B 04 4F 04 35 04 42 04 20 00   // B.0.2.;.O.5.B. .
                                    7B 00 30 00 7D 00 )                               // {.0.}.
    IL_0005:  ldarg.0
    IL_0006:  call       instance int32 lesson7.Lohotron::get_Remain()
    IL_000b:  box        [mscorlib]System.Int32
    IL_0010:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0015:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001a:  ret
  } // end of method Lohotron::ShowRemain

  .method private hidebysig instance void 
          GetWinningBid() cil managed
  {
    // Размер кода:       59 (0x3b)
    .maxstack  4
    .locals init ([0] class [mscorlib]System.Random rnd)
    IL_0000:  newobj     instance void [mscorlib]System.Random::.ctor()
    IL_0005:  stloc.0
    IL_0006:  ldarg.0
    IL_0007:  ldloc.0
    IL_0008:  ldc.i4.0
    IL_0009:  ldc.i4.s   9
    IL_000b:  callvirt   instance int32 [mscorlib]System.Random::Next(int32,
                                                                      int32)
    IL_0010:  stfld      int32 lesson7.Lohotron::_winningBid
    IL_0015:  ldstr      bytearray (12 04 30 04 48 04 30 04 20 00 41 04 42 04 30 04   // ..0.H.0. .A.B.0.
                                    32 04 3A 04 30 04 20 00 7B 00 30 00 7D 00 2C 00   // 2.:.0. .{.0.}.,.
                                    20 00 32 04 4B 04 3F 04 30 04 3B 04 3E 04 20 00   //  .2.K.?.0.;.>. .
                                    7B 00 31 00 7D 00 20 00 )                         // {.1.}. .
    IL_001a:  ldarg.0
    IL_001b:  call       instance int32 lesson7.Lohotron::get_Bet()
    IL_0020:  box        [mscorlib]System.Int32
    IL_0025:  ldarg.0
    IL_0026:  call       instance int32 lesson7.Lohotron::get_WinningBid()
    IL_002b:  box        [mscorlib]System.Int32
    IL_0030:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_0035:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_003a:  ret
  } // end of method Lohotron::GetWinningBid

  .method public hidebysig instance void 
          TurnTheWheel() cil managed
  {
    // Размер кода:       122 (0x7a)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  call       instance bool lesson7.Lohotron::get_ReadyToPlay()
    IL_0006:  brtrue.s   IL_0013

    IL_0008:  ldstr      bytearray (20 00 1F 04 3E 04 3F 04 3E 04 3B 04 3D 04 38 04   //  ...>.?.>.;.=.8.
                                    42 04 35 04 20 00 41 04 47 04 35 04 42 04 20 00   // B.5. .A.G.5.B. .
                                    38 04 2F 00 38 04 3B 04 38 04 20 00 41 04 34 04   // 8./.8.;.8. .A.4.
                                    35 04 3B 04 30 04 39 04 42 04 35 04 20 00 41 04   // 5.;.0.9.B.5. .A.
                                    42 04 30 04 32 04 3A 04 43 04 )                   // B.0.2.:.C.
    IL_000d:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0012:  ret

    IL_0013:  ldarg.0
    IL_0014:  call       instance void lesson7.Lohotron::GetWinningBid()
    IL_0019:  ldarg.0
    IL_001a:  call       instance int32 lesson7.Lohotron::get_Bet()
    IL_001f:  ldarg.0
    IL_0020:  call       instance int32 lesson7.Lohotron::get_WinningBid()
    IL_0025:  bne.un.s   IL_0027

    IL_0027:  ldstr      bytearray (12 04 4B 04 20 00 32 04 4B 04 38 04 33 04 40 04   // ..K. .2.K.8.3.@.
                                    30 04 3B 04 38 04 )                               // 0.;.8.
    IL_002c:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0031:  ldarg.0
    IL_0032:  ldarg.0
    IL_0033:  call       instance int32 lesson7.Lohotron::get_Remain()
    IL_0038:  ldarg.0
    IL_0039:  call       instance int32 lesson7.Lohotron::get_BidAmount()
    IL_003e:  add
    IL_003f:  call       instance void lesson7.Lohotron::set_Remain(int32)
    IL_0044:  br.s       IL_0063

    IL_0046:  ldstr      bytearray (12 04 4B 04 20 00 3F 04 40 04 3E 04 38 04 33 04   // ..K. .?.@.>.8.3.
                                    40 04 30 04 3B 04 38 04 )                         // @.0.;.8.
    IL_004b:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0050:  ldarg.0
    IL_0051:  ldarg.0
    IL_0052:  call       instance int32 lesson7.Lohotron::get_Remain()
    IL_0057:  ldarg.0
    IL_0058:  call       instance int32 lesson7.Lohotron::get_BidAmount()
    IL_005d:  sub
    IL_005e:  call       instance void lesson7.Lohotron::set_Remain(int32)
    IL_0063:  ldarg.0
    IL_0064:  call       instance void lesson7.Lohotron::ShowRemain()
    IL_0069:  ldstr      bytearray (14 04 3B 04 4F 04 20 00 3F 04 40 04 3E 04 34 04   // ..;.O. .?.@.>.4.
                                    3E 04 3B 04 36 04 35 04 3D 04 38 04 4F 04 20 00   // >.;.6.5.=.8.O. .
                                    3D 04 30 04 36 04 3C 04 38 04 42 04 35 04 20 00   // =.0.6.<.8.B.5. .
                                    3B 04 4E 04 31 04 43 04 4E 04 20 00 3A 04 3B 04   // ;.N.1.C.N. .:.;.
                                    30 04 32 04 38 04 48 04 43 04 )                   // 0.2.8.H.C.
    IL_006e:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0073:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_0078:  pop
    IL_0079:  ret
  } // end of method Lohotron::TurnTheWheel

  .method public hidebysig instance void 
          SayGoodbye() cil managed
  {
    // Размер кода:       17 (0x11)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void lesson7.Lohotron::ShowRemain()
    IL_0006:  ldstr      bytearray (14 04 3E 04 20 00 41 04 3B 04 35 04 34 04 43 04   // ..>. .A.;.5.4.C.
                                    4E 04 49 04 38 04 45 04 20 00 32 04 41 04 42 04   // N.I.8.E. .2.A.B.
                                    40 04 35 04 47 04 20 00 2E 00 2E 00 2E 00 2E 00   // @.5.G. .........
                                    20 00 )                                           //  .
    IL_000b:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0010:  ret
  } // end of method Lohotron::SayGoodbye

  .property instance int32 Remain()
  {
    .get instance int32 lesson7.Lohotron::get_Remain()
    .set instance void lesson7.Lohotron::set_Remain(int32)
  } // end of property Lohotron::Remain
  .property instance int32 Bet()
  {
    .get instance int32 lesson7.Lohotron::get_Bet()
    .set instance void lesson7.Lohotron::set_Bet(int32)
  } // end of property Lohotron::Bet
  .property instance int32 WinningBid()
  {
    .get instance int32 lesson7.Lohotron::get_WinningBid()
  } // end of property Lohotron::WinningBid
  .property instance int32 BidAmount()
  {
    .get instance int32 lesson7.Lohotron::get_BidAmount()
  } // end of property Lohotron::BidAmount
  .property instance bool ReadyToPlay()
  {
    .get instance bool lesson7.Lohotron::get_ReadyToPlay()
  } // end of property Lohotron::ReadyToPlay
} // end of class lesson7.Lohotron

.class private auto ansi beforefieldinit lesson7.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       120 (0x78)
    .maxstack  2
    .locals init ([0] char command,
             [1] class lesson7.Lohotron lohotron,
             [2] valuetype [mscorlib]System.ConsoleKeyInfo V_2)
    IL_0000:  ldc.i4.s   100
    IL_0002:  newobj     instance void lesson7.Lohotron::.ctor(int32)
    IL_0007:  stloc.1
    IL_0008:  call       void [mscorlib]System.Console::Clear()
    IL_000d:  ldloc.1
    IL_000e:  callvirt   instance void lesson7.Lohotron::ShowRemain()
    IL_0013:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    3A 04 3E 04 34 04 20 00 3A 04 3E 04 3C 04 30 04   // :.>.4. .:.>.<.0.
                                    3D 04 34 04 4B 04 20 00 28 00 31 00 2D 00 32 04   // =.4.K. .(.1.-.2.
                                    3D 04 35 04 41 04 42 04 38 04 20 00 34 04 35 04   // =.5.A.B.8. .4.5.
                                    3D 04 4C 04 33 04 38 04 2C 00 20 00 32 00 2D 00   // =.L.3.8.,. .2.-.
                                    41 04 34 04 35 04 3B 04 30 04 42 04 4C 04 20 00   // A.4.5.;.0.B.L. .
                                    41 04 42 04 30 04 32 04 3A 04 43 04 2C 00 20 00   // A.B.0.2.:.C.,. .
                                    33 00 20 00 2D 00 20 00 38 04 33 04 40 04 30 04   // 3. .-. .8.3.@.0.
                                    42 04 4C 04 2C 00 20 00 34 00 20 00 2D 00 20 00   // B.L.,. .4. .-. .
                                    32 04 4B 04 39 04 42 04 38 04 29 00 3A 00 20 00 ) // 2.K.9.B.8.).:. .
    IL_0018:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001d:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_0022:  stloc.2
    IL_0023:  ldloca.s   V_2
    IL_0025:  call       instance char [mscorlib]System.ConsoleKeyInfo::get_KeyChar()
    IL_002a:  stloc.0
    IL_002b:  ldc.i4.0
    IL_002c:  ldc.i4.2
    IL_002d:  call       void [mscorlib]System.Console::SetCursorPosition(int32,
                                                                          int32)
    IL_0032:  ldloc.0
    IL_0033:  ldc.i4.s   49
    IL_0035:  sub
    IL_0036:  switch     ( 
                          IL_004d,
                          IL_0055,
                          IL_005d,
                          IL_0065)
    IL_004b:  br.s       IL_006c

    IL_004d:  ldloc.1
    IL_004e:  callvirt   instance void lesson7.Lohotron::GetMoney()
    IL_0053:  br.s       IL_0008

    IL_0055:  ldloc.1
    IL_0056:  callvirt   instance void lesson7.Lohotron::GetBet()
    IL_005b:  br.s       IL_0008

    IL_005d:  ldloc.1
    IL_005e:  callvirt   instance void lesson7.Lohotron::TurnTheWheel()
    IL_0063:  br.s       IL_0008

    IL_0065:  ldloc.1
    IL_0066:  callvirt   instance void lesson7.Lohotron::SayGoodbye()
    IL_006b:  ret

    IL_006c:  ldstr      bytearray (1D 04 35 04 42 04 20 00 42 04 30 04 3A 04 3E 04   // ..5.B. .B.0.:.>.
                                    39 04 20 00 3A 04 3E 04 3C 04 30 04 3D 04 34 04   // 9. .:.>.<.0.=.4.
                                    4B 04 )                                           // K.
    IL_0071:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0076:  br.s       IL_0008
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class lesson7.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 D:\CSharpProj\geekbrains\Introduction\lesson7aa\bin\Release\cracked.res

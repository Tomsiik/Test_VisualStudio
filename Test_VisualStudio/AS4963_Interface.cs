using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AS4963_Interface

{
    public static class AS4963
    {
        public static class C0
        {
            public static class BT
            {
                public const ushort Pos = 6;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
            public static class RM
            {
                public const ushort Pos = 10;
                public const ushort Num = 2;
                public static ushort Mask = Convert.ToUInt16(0x03 << Pos);
            }
            public static class DT
            {
                public const ushort Pos = 0;
                public const ushort Num = 6;
                public static ushort Mask = Convert.ToUInt16(0x3F << Pos);
            }

        }

        public static class C1
        {
            public static class PFD
            {
                public const ushort Pos = 11;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class IPI
            {
                public const ushort Pos = 10;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class VIL
            {
                public const ushort Pos = 6;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
            public static class VDQ
            {
                public const ushort Pos = 5;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class VT
            {
                public const ushort Pos = 0;
                public const ushort Num = 5;
                public static ushort Mask = Convert.ToUInt16(0x1F << Pos);
            }
        }

        public static class C2
        {
            public static class CP
            {
                public const ushort Pos = 8;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
            public static class SH
            {
                public const ushort Pos = 6;
                public const ushort Num = 2;
                public static ushort Mask = Convert.ToUInt16(0x03 << Pos);
            }
            public static class DGC
            {
                public const ushort Pos = 5;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class PW
            {
                public const ushort Pos = 0;
                public const ushort Num = 5;
                public static ushort Mask = Convert.ToUInt16(0x1F << Pos);
            }
        }

        public static class C3
        {
            public static class CI
            {
                public const ushort Pos = 8;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
            public static class HD
            {
                public const ushort Pos = 4;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
            public static class HT
            {
                public const ushort Pos = 0;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
        }

        public static class C4
        {
            public static class SP
            {
                public const ushort Pos = 8;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
            public static class SD
            {
                public const ushort Pos = 4;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
            public static class SS
            {
                public const ushort Pos = 0;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
        }

        public static class C5
        {
            public static class SI
            {
                public const ushort Pos = 8;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
            public static class SPO
            {
                public const ushort Pos = 7;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class SMX
            {
                public const ushort Pos = 4;
                public const ushort Num = 3;
                public static ushort Mask = Convert.ToUInt16(0x07 << Pos);
            }
            public static class PA
            {
                public const ushort Pos = 0;
                public const ushort Num = 4;
                public static ushort Mask = Convert.ToUInt16(0x0F << Pos);
            }
        }


        public static class MASK
        {
            public static class TW
            {
                public const ushort Pos = 11;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class OT
            {
                public const ushort Pos = 10;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class LOS
            {
                public const ushort Pos = 9;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class VS
            {
                public const ushort Pos = 7;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class AH
            {
                public const ushort Pos = 5;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class AL
            {
                public const ushort Pos = 4;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class BH
            {
                public const ushort Pos = 3;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class BL
            {
                public const ushort Pos = 2;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class CH
            {
                public const ushort Pos = 1;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class CL
            {
                public const ushort Pos = 0;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
        }

        public static class RUN
        {
            public static class CM
            {
                public const ushort Pos = 10;
                public const ushort Num = 2;
                public static ushort Mask = Convert.ToUInt16(0x03 << Pos);
            }
            public static class ESF
            {
                public const ushort Pos = 9;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class DI
            {
                public const ushort Pos = 4;
                public const ushort Num = 5;
                public static ushort Mask = Convert.ToUInt16(0x1F << Pos);
            }
            public static class RSC
            {
                public const ushort Pos = 3;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class BRK
            {
                public const ushort Pos = 2;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class DIR
            {
                public const ushort Pos = 1;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class RRUN
            {
                public const ushort Pos = 0;
                public const ushort Num = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
        }

        public static class DIAG
        {
            public static class CL
            {
                public const ushort Pos = 0;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class CH
            {
                public const ushort Pos = 1;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class BL
            {
                public const ushort Pos = 2;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class BH
            {
                public const ushort Pos = 3;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class AL
            {
                public const ushort Pos = 4;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class AH
            {
                public const ushort Pos = 5;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class VS
            {
                public const ushort Pos = 7;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class LOS
            {
                public const ushort Pos = 9;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class OT
            {
                public const ushort Pos = 10;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class TW
            {
                public const ushort Pos = 11;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class SE
            {
                public const ushort Pos = 13;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class POR
            {
                public const ushort Pos = 14;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
            public static class FF
            {
                public const ushort Pos = 15;
                public static ushort Mask = Convert.ToUInt16(0x01 << Pos);
            }
        }





        public static class ModifyReg
        {

            public static ushort ConfigReg0(ushort rm, ushort bt, ushort dt)
            {
                ushort Reg0 = 0;
                Reg0 |= Convert.ToUInt16((Reg0 & (~C0.BT.Mask)) | Convert.ToUInt16(bt << C0.BT.Pos));
                Reg0 |= Convert.ToUInt16((Reg0 & (~C0.RM.Mask)) | Convert.ToUInt16(rm << C0.RM.Pos));
                Reg0 |= Convert.ToUInt16((Reg0 & (~C0.DT.Mask)) | Convert.ToUInt16(dt << C0.DT.Pos));
                return Reg0;
            }

            public static ushort ConfigReg1(ushort pfd, ushort ipi, ushort vil, ushort vdq, ushort vt)
            {
                ushort Reg1 = 0;
                Reg1 |= Convert.ToUInt16((Reg1 & (~C1.PFD.Mask)) | Convert.ToUInt16(pfd << C1.PFD.Pos));
                Reg1 |= Convert.ToUInt16((Reg1 & (~C1.IPI.Mask)) | Convert.ToUInt16(ipi << C1.IPI.Pos));
                Reg1 |= Convert.ToUInt16((Reg1 & (~C1.VIL.Mask)) | Convert.ToUInt16(vil << C1.VIL.Pos));
                Reg1 |= Convert.ToUInt16((Reg1 & (~C1.VDQ.Mask)) | Convert.ToUInt16(vdq << C1.VDQ.Pos));
                Reg1 |= Convert.ToUInt16((Reg1 & (~C1.VT.Mask)) | Convert.ToUInt16(vt << C1.VT.Pos));
                return Reg1;
            }

            public static ushort ConfigReg2(ushort cp, ushort sh, ushort dgc, ushort pw)
            {
                ushort Reg2 = 0;
                Reg2 |= Convert.ToUInt16((Reg2 & (~C2.CP.Mask)) | Convert.ToUInt16(cp << C2.CP.Pos));
                Reg2 |= Convert.ToUInt16((Reg2 & (~C2.SH.Mask)) | Convert.ToUInt16(sh << C2.SH.Pos));
                Reg2 |= Convert.ToUInt16((Reg2 & (~C2.DGC.Mask)) | Convert.ToUInt16(dgc << C2.DGC.Pos));
                Reg2 |= Convert.ToUInt16((Reg2 & (~C2.PW.Mask)) | Convert.ToUInt16(pw << C2.PW.Pos));
                return Reg2;
            }

            public static ushort ConfigReg3(ushort ci, ushort hd, ushort ht)
            {
                ushort Reg3 = 0;
                Reg3 |= Convert.ToUInt16((Reg3 & (~C3.CI.Mask)) | Convert.ToUInt16(ci << C3.CI.Pos));
                Reg3 |= Convert.ToUInt16((Reg3 & (~C3.HD.Mask)) | Convert.ToUInt16(hd << C3.HD.Pos));
                Reg3 |= Convert.ToUInt16((Reg3 & (~C3.HT.Mask)) | Convert.ToUInt16(ht << C3.HT.Pos));
                return Reg3;
            }

            public static ushort ConfigReg4(ushort sp, ushort sd, ushort ss)
            {
                ushort Reg4 = 0;
                Reg4 |= Convert.ToUInt16((Reg4 & (~C4.SP.Mask)) | Convert.ToUInt16(sp << C4.SP.Pos));
                Reg4 |= Convert.ToUInt16((Reg4 & (~C4.SD.Mask)) | Convert.ToUInt16(sd << C4.SD.Pos));
                Reg4 |= Convert.ToUInt16((Reg4 & (~C4.SS.Mask)) | Convert.ToUInt16(ss << C4.SS.Pos));
                return Reg4;
            }

            public static ushort ConfigReg5(ushort si, ushort spo, ushort smx, ushort pa)
            {
                ushort Reg5 = 0;
                Reg5 |= Convert.ToUInt16((Reg5 & (~C5.SI.Mask)) | Convert.ToUInt16(si << C5.SI.Pos));
                Reg5 |= Convert.ToUInt16((Reg5 & (~C5.SPO.Mask)) | Convert.ToUInt16(spo << C5.SPO.Pos));
                Reg5 |= Convert.ToUInt16((Reg5 & (~C5.SMX.Mask)) | Convert.ToUInt16(smx << C5.SMX.Pos));
                Reg5 |= Convert.ToUInt16((Reg5 & (~C5.PA.Mask)) | Convert.ToUInt16(pa << C5.PA.Pos));
                return Reg5;
            }

            public static ushort RunReg(ushort cm, ushort esf, ushort di, ushort rsc, ushort brk, ushort dir, ushort run)
            {
                ushort Run = 0;
                Run |= Convert.ToUInt16((Run & (~RUN.CM.Mask)) | Convert.ToUInt16(cm << RUN.CM.Pos));
                Run |= Convert.ToUInt16((Run & (~RUN.ESF.Mask)) | Convert.ToUInt16(esf << RUN.ESF.Pos));
                Run |= Convert.ToUInt16((Run & (~RUN.DI.Mask)) | Convert.ToUInt16(di << RUN.DI.Pos));
                Run |= Convert.ToUInt16((Run & (~RUN.RSC.Mask)) | Convert.ToUInt16(rsc << RUN.RSC.Pos));
                Run |= Convert.ToUInt16((Run & (~RUN.BRK.Mask)) | Convert.ToUInt16(brk << RUN.BRK.Pos));
                Run |= Convert.ToUInt16((Run & (~RUN.DIR.Mask)) | Convert.ToUInt16(dir << RUN.DIR.Pos));
                Run |= Convert.ToUInt16((Run & (~RUN.RRUN.Mask)) | Convert.ToUInt16(run << RUN.RRUN.Pos));
                return Run;
            }


        }

    }
}




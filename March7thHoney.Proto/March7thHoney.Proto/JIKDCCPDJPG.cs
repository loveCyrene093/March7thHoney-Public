using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JIKDCCPDJPG : IMessage<JIKDCCPDJPG>, IMessage, IEquatable<JIKDCCPDJPG>, IDeepCloneable<JIKDCCPDJPG>, IBufferMessage
{
	private static readonly MessageParser<JIKDCCPDJPG> _parser = new MessageParser<JIKDCCPDJPG>(() => new JIKDCCPDJPG());

	private UnknownFieldSet _unknownFields;

	public const int LGIIKHCKBMEFieldNumber = 1;

	private static readonly FieldCodec<KINHLMIMDIG> _repeated_lGIIKHCKBME_codec = FieldCodec.ForMessage(10u, KINHLMIMDIG.Parser);

	private readonly RepeatedField<KINHLMIMDIG> lGIIKHCKBME_ = new RepeatedField<KINHLMIMDIG>();

	public const int FBCJCKEAHCMFieldNumber = 3;

	private uint fBCJCKEAHCM_;

	public const int IsWinFieldNumber = 5;

	private bool isWin_;

	public const int DEMGBJCJGNOFieldNumber = 7;

	private NAKGMGHLKFP dEMGBJCJGNO_;

	public const int DHFKOKJIBNEFieldNumber = 13;

	private int dHFKOKJIBNE_;

	public const int AKGLMBNKHLGFieldNumber = 14;

	private uint aKGLMBNKHLG_;

	public const int NHLGOCGMKBPFieldNumber = 15;

	private bool nHLGOCGMKBP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JIKDCCPDJPG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JIKDCCPDJPGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KINHLMIMDIG> LGIIKHCKBME => lGIIKHCKBME_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FBCJCKEAHCM
	{
		get
		{
			return fBCJCKEAHCM_;
		}
		set
		{
			fBCJCKEAHCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAKGMGHLKFP DEMGBJCJGNO
	{
		get
		{
			return dEMGBJCJGNO_;
		}
		set
		{
			dEMGBJCJGNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DHFKOKJIBNE
	{
		get
		{
			return dHFKOKJIBNE_;
		}
		set
		{
			dHFKOKJIBNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AKGLMBNKHLG
	{
		get
		{
			return aKGLMBNKHLG_;
		}
		set
		{
			aKGLMBNKHLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NHLGOCGMKBP
	{
		get
		{
			return nHLGOCGMKBP_;
		}
		set
		{
			nHLGOCGMKBP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIKDCCPDJPG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIKDCCPDJPG(JIKDCCPDJPG other)
		: this()
	{
		lGIIKHCKBME_ = other.lGIIKHCKBME_.Clone();
		fBCJCKEAHCM_ = other.fBCJCKEAHCM_;
		isWin_ = other.isWin_;
		dEMGBJCJGNO_ = other.dEMGBJCJGNO_;
		dHFKOKJIBNE_ = other.dHFKOKJIBNE_;
		aKGLMBNKHLG_ = other.aKGLMBNKHLG_;
		nHLGOCGMKBP_ = other.nHLGOCGMKBP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIKDCCPDJPG Clone()
	{
		return new JIKDCCPDJPG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JIKDCCPDJPG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JIKDCCPDJPG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lGIIKHCKBME_.Equals(other.lGIIKHCKBME_))
		{
			return false;
		}
		if (FBCJCKEAHCM != other.FBCJCKEAHCM)
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (DEMGBJCJGNO != other.DEMGBJCJGNO)
		{
			return false;
		}
		if (DHFKOKJIBNE != other.DHFKOKJIBNE)
		{
			return false;
		}
		if (AKGLMBNKHLG != other.AKGLMBNKHLG)
		{
			return false;
		}
		if (NHLGOCGMKBP != other.NHLGOCGMKBP)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		num ^= lGIIKHCKBME_.GetHashCode();
		if (FBCJCKEAHCM != 0)
		{
			num ^= FBCJCKEAHCM.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (DEMGBJCJGNO != NAKGMGHLKFP.Hpdehdjmibg)
		{
			num ^= DEMGBJCJGNO.GetHashCode();
		}
		if (DHFKOKJIBNE != 0)
		{
			num ^= DHFKOKJIBNE.GetHashCode();
		}
		if (AKGLMBNKHLG != 0)
		{
			num ^= AKGLMBNKHLG.GetHashCode();
		}
		if (NHLGOCGMKBP)
		{
			num ^= NHLGOCGMKBP.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		lGIIKHCKBME_.WriteTo(ref output, _repeated_lGIIKHCKBME_codec);
		if (FBCJCKEAHCM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FBCJCKEAHCM);
		}
		if (IsWin)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsWin);
		}
		if (DEMGBJCJGNO != NAKGMGHLKFP.Hpdehdjmibg)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)DEMGBJCJGNO);
		}
		if (DHFKOKJIBNE != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(DHFKOKJIBNE);
		}
		if (AKGLMBNKHLG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AKGLMBNKHLG);
		}
		if (NHLGOCGMKBP)
		{
			output.WriteRawTag(120);
			output.WriteBool(NHLGOCGMKBP);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		num += lGIIKHCKBME_.CalculateSize(_repeated_lGIIKHCKBME_codec);
		if (FBCJCKEAHCM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBCJCKEAHCM);
		}
		if (IsWin)
		{
			num += 2;
		}
		if (DEMGBJCJGNO != NAKGMGHLKFP.Hpdehdjmibg)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DEMGBJCJGNO);
		}
		if (DHFKOKJIBNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DHFKOKJIBNE);
		}
		if (AKGLMBNKHLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AKGLMBNKHLG);
		}
		if (NHLGOCGMKBP)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JIKDCCPDJPG other)
	{
		if (other != null)
		{
			lGIIKHCKBME_.Add(other.lGIIKHCKBME_);
			if (other.FBCJCKEAHCM != 0)
			{
				FBCJCKEAHCM = other.FBCJCKEAHCM;
			}
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			if (other.DEMGBJCJGNO != NAKGMGHLKFP.Hpdehdjmibg)
			{
				DEMGBJCJGNO = other.DEMGBJCJGNO;
			}
			if (other.DHFKOKJIBNE != 0)
			{
				DHFKOKJIBNE = other.DHFKOKJIBNE;
			}
			if (other.AKGLMBNKHLG != 0)
			{
				AKGLMBNKHLG = other.AKGLMBNKHLG;
			}
			if (other.NHLGOCGMKBP)
			{
				NHLGOCGMKBP = other.NHLGOCGMKBP;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
				lGIIKHCKBME_.AddEntriesFrom(ref input, _repeated_lGIIKHCKBME_codec);
				break;
			case 24u:
				FBCJCKEAHCM = input.ReadUInt32();
				break;
			case 40u:
				IsWin = input.ReadBool();
				break;
			case 56u:
				DEMGBJCJGNO = (NAKGMGHLKFP)input.ReadEnum();
				break;
			case 104u:
				DHFKOKJIBNE = input.ReadInt32();
				break;
			case 112u:
				AKGLMBNKHLG = input.ReadUInt32();
				break;
			case 120u:
				NHLGOCGMKBP = input.ReadBool();
				break;
			}
		}
	}
}

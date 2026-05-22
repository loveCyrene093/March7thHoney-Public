using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LAOOIHPKMOO : IMessage<LAOOIHPKMOO>, IMessage, IEquatable<LAOOIHPKMOO>, IDeepCloneable<LAOOIHPKMOO>, IBufferMessage
{
	private static readonly MessageParser<LAOOIHPKMOO> _parser = new MessageParser<LAOOIHPKMOO>(() => new LAOOIHPKMOO());

	private UnknownFieldSet _unknownFields;

	public const int IsWinFieldNumber = 5;

	private bool isWin_;

	public const int NHLGOCGMKBPFieldNumber = 6;

	private bool nHLGOCGMKBP_;

	public const int DLCKBMLMOIPFieldNumber = 8;

	private int dLCKBMLMOIP_;

	public const int GIHDGLMJMHCFieldNumber = 10;

	private uint gIHDGLMJMHC_;

	public const int FOOLMIADMMHFieldNumber = 13;

	private uint fOOLMIADMMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LAOOIHPKMOO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LAOOIHPKMOOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int DLCKBMLMOIP
	{
		get
		{
			return dLCKBMLMOIP_;
		}
		set
		{
			dLCKBMLMOIP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GIHDGLMJMHC
	{
		get
		{
			return gIHDGLMJMHC_;
		}
		set
		{
			gIHDGLMJMHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FOOLMIADMMH
	{
		get
		{
			return fOOLMIADMMH_;
		}
		set
		{
			fOOLMIADMMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LAOOIHPKMOO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LAOOIHPKMOO(LAOOIHPKMOO other)
		: this()
	{
		isWin_ = other.isWin_;
		nHLGOCGMKBP_ = other.nHLGOCGMKBP_;
		dLCKBMLMOIP_ = other.dLCKBMLMOIP_;
		gIHDGLMJMHC_ = other.gIHDGLMJMHC_;
		fOOLMIADMMH_ = other.fOOLMIADMMH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LAOOIHPKMOO Clone()
	{
		return new LAOOIHPKMOO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LAOOIHPKMOO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LAOOIHPKMOO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (NHLGOCGMKBP != other.NHLGOCGMKBP)
		{
			return false;
		}
		if (DLCKBMLMOIP != other.DLCKBMLMOIP)
		{
			return false;
		}
		if (GIHDGLMJMHC != other.GIHDGLMJMHC)
		{
			return false;
		}
		if (FOOLMIADMMH != other.FOOLMIADMMH)
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
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (NHLGOCGMKBP)
		{
			num ^= NHLGOCGMKBP.GetHashCode();
		}
		if (DLCKBMLMOIP != 0)
		{
			num ^= DLCKBMLMOIP.GetHashCode();
		}
		if (GIHDGLMJMHC != 0)
		{
			num ^= GIHDGLMJMHC.GetHashCode();
		}
		if (FOOLMIADMMH != 0)
		{
			num ^= FOOLMIADMMH.GetHashCode();
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
		if (IsWin)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsWin);
		}
		if (NHLGOCGMKBP)
		{
			output.WriteRawTag(48);
			output.WriteBool(NHLGOCGMKBP);
		}
		if (DLCKBMLMOIP != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(DLCKBMLMOIP);
		}
		if (GIHDGLMJMHC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GIHDGLMJMHC);
		}
		if (FOOLMIADMMH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FOOLMIADMMH);
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
		if (IsWin)
		{
			num += 2;
		}
		if (NHLGOCGMKBP)
		{
			num += 2;
		}
		if (DLCKBMLMOIP != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DLCKBMLMOIP);
		}
		if (GIHDGLMJMHC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GIHDGLMJMHC);
		}
		if (FOOLMIADMMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOOLMIADMMH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LAOOIHPKMOO other)
	{
		if (other != null)
		{
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			if (other.NHLGOCGMKBP)
			{
				NHLGOCGMKBP = other.NHLGOCGMKBP;
			}
			if (other.DLCKBMLMOIP != 0)
			{
				DLCKBMLMOIP = other.DLCKBMLMOIP;
			}
			if (other.GIHDGLMJMHC != 0)
			{
				GIHDGLMJMHC = other.GIHDGLMJMHC;
			}
			if (other.FOOLMIADMMH != 0)
			{
				FOOLMIADMMH = other.FOOLMIADMMH;
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
			case 40u:
				IsWin = input.ReadBool();
				break;
			case 48u:
				NHLGOCGMKBP = input.ReadBool();
				break;
			case 64u:
				DLCKBMLMOIP = input.ReadInt32();
				break;
			case 80u:
				GIHDGLMJMHC = input.ReadUInt32();
				break;
			case 104u:
				FOOLMIADMMH = input.ReadUInt32();
				break;
			}
		}
	}
}

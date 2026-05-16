using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OFLEELGMBIO : IMessage<OFLEELGMBIO>, IMessage, IEquatable<OFLEELGMBIO>, IDeepCloneable<OFLEELGMBIO>, IBufferMessage
{
	public enum BHKPAMDFGAAOneofCase
	{
		None = 0,
		GNDJPNBECJP = 321,
		CDDLJOJAHOA = 1303,
		NHKHKKFBDEN = 1500
	}

	private static readonly MessageParser<OFLEELGMBIO> _parser = new MessageParser<OFLEELGMBIO>(() => new OFLEELGMBIO());

	private UnknownFieldSet _unknownFields;

	public const int GNDJPNBECJPFieldNumber = 321;

	public const int CDDLJOJAHOAFieldNumber = 1303;

	public const int NHKHKKFBDENFieldNumber = 1500;

	private object bHKPAMDFGAA_;

	private BHKPAMDFGAAOneofCase bHKPAMDFGAACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OFLEELGMBIO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OFLEELGMBIOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GNDJPNBECJP
	{
		get
		{
			if (!HasGNDJPNBECJP)
			{
				return false;
			}
			return (bool)bHKPAMDFGAA_;
		}
		set
		{
			bHKPAMDFGAA_ = value;
			bHKPAMDFGAACase_ = BHKPAMDFGAAOneofCase.GNDJPNBECJP;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGNDJPNBECJP => bHKPAMDFGAACase_ == BHKPAMDFGAAOneofCase.GNDJPNBECJP;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFKDIEAJPCJ CDDLJOJAHOA
	{
		get
		{
			if (bHKPAMDFGAACase_ != BHKPAMDFGAAOneofCase.CDDLJOJAHOA)
			{
				return null;
			}
			return (KFKDIEAJPCJ)bHKPAMDFGAA_;
		}
		set
		{
			bHKPAMDFGAA_ = value;
			bHKPAMDFGAACase_ = ((value != null) ? BHKPAMDFGAAOneofCase.CDDLJOJAHOA : BHKPAMDFGAAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFKDIEAJPCJ NHKHKKFBDEN
	{
		get
		{
			if (bHKPAMDFGAACase_ != BHKPAMDFGAAOneofCase.NHKHKKFBDEN)
			{
				return null;
			}
			return (KFKDIEAJPCJ)bHKPAMDFGAA_;
		}
		set
		{
			bHKPAMDFGAA_ = value;
			bHKPAMDFGAACase_ = ((value != null) ? BHKPAMDFGAAOneofCase.NHKHKKFBDEN : BHKPAMDFGAAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHKPAMDFGAAOneofCase BHKPAMDFGAACase => bHKPAMDFGAACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFLEELGMBIO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFLEELGMBIO(OFLEELGMBIO other)
		: this()
	{
		switch (other.BHKPAMDFGAACase)
		{
		case BHKPAMDFGAAOneofCase.GNDJPNBECJP:
			GNDJPNBECJP = other.GNDJPNBECJP;
			break;
		case BHKPAMDFGAAOneofCase.CDDLJOJAHOA:
			CDDLJOJAHOA = other.CDDLJOJAHOA.Clone();
			break;
		case BHKPAMDFGAAOneofCase.NHKHKKFBDEN:
			NHKHKKFBDEN = other.NHKHKKFBDEN.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFLEELGMBIO Clone()
	{
		return new OFLEELGMBIO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGNDJPNBECJP()
	{
		if (HasGNDJPNBECJP)
		{
			ClearBHKPAMDFGAA();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBHKPAMDFGAA()
	{
		bHKPAMDFGAACase_ = BHKPAMDFGAAOneofCase.None;
		bHKPAMDFGAA_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OFLEELGMBIO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OFLEELGMBIO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GNDJPNBECJP != other.GNDJPNBECJP)
		{
			return false;
		}
		if (!object.Equals(CDDLJOJAHOA, other.CDDLJOJAHOA))
		{
			return false;
		}
		if (!object.Equals(NHKHKKFBDEN, other.NHKHKKFBDEN))
		{
			return false;
		}
		if (BHKPAMDFGAACase != other.BHKPAMDFGAACase)
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
		if (HasGNDJPNBECJP)
		{
			num ^= GNDJPNBECJP.GetHashCode();
		}
		if (bHKPAMDFGAACase_ == BHKPAMDFGAAOneofCase.CDDLJOJAHOA)
		{
			num ^= CDDLJOJAHOA.GetHashCode();
		}
		if (bHKPAMDFGAACase_ == BHKPAMDFGAAOneofCase.NHKHKKFBDEN)
		{
			num ^= NHKHKKFBDEN.GetHashCode();
		}
		num ^= (int)bHKPAMDFGAACase_;
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
		if (HasGNDJPNBECJP)
		{
			output.WriteRawTag(136, 20);
			output.WriteBool(GNDJPNBECJP);
		}
		if (bHKPAMDFGAACase_ == BHKPAMDFGAAOneofCase.CDDLJOJAHOA)
		{
			output.WriteRawTag(186, 81);
			output.WriteMessage(CDDLJOJAHOA);
		}
		if (bHKPAMDFGAACase_ == BHKPAMDFGAAOneofCase.NHKHKKFBDEN)
		{
			output.WriteRawTag(226, 93);
			output.WriteMessage(NHKHKKFBDEN);
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
		if (HasGNDJPNBECJP)
		{
			num += 3;
		}
		if (bHKPAMDFGAACase_ == BHKPAMDFGAAOneofCase.CDDLJOJAHOA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CDDLJOJAHOA);
		}
		if (bHKPAMDFGAACase_ == BHKPAMDFGAAOneofCase.NHKHKKFBDEN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NHKHKKFBDEN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OFLEELGMBIO other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BHKPAMDFGAACase)
		{
		case BHKPAMDFGAAOneofCase.GNDJPNBECJP:
			GNDJPNBECJP = other.GNDJPNBECJP;
			break;
		case BHKPAMDFGAAOneofCase.CDDLJOJAHOA:
			if (CDDLJOJAHOA == null)
			{
				CDDLJOJAHOA = new KFKDIEAJPCJ();
			}
			CDDLJOJAHOA.MergeFrom(other.CDDLJOJAHOA);
			break;
		case BHKPAMDFGAAOneofCase.NHKHKKFBDEN:
			if (NHKHKKFBDEN == null)
			{
				NHKHKKFBDEN = new KFKDIEAJPCJ();
			}
			NHKHKKFBDEN.MergeFrom(other.NHKHKKFBDEN);
			break;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 2568u:
				GNDJPNBECJP = input.ReadBool();
				break;
			case 10426u:
			{
				KFKDIEAJPCJ kFKDIEAJPCJ2 = new KFKDIEAJPCJ();
				if (bHKPAMDFGAACase_ == BHKPAMDFGAAOneofCase.CDDLJOJAHOA)
				{
					kFKDIEAJPCJ2.MergeFrom(CDDLJOJAHOA);
				}
				input.ReadMessage(kFKDIEAJPCJ2);
				CDDLJOJAHOA = kFKDIEAJPCJ2;
				break;
			}
			case 12002u:
			{
				KFKDIEAJPCJ kFKDIEAJPCJ = new KFKDIEAJPCJ();
				if (bHKPAMDFGAACase_ == BHKPAMDFGAAOneofCase.NHKHKKFBDEN)
				{
					kFKDIEAJPCJ.MergeFrom(NHKHKKFBDEN);
				}
				input.ReadMessage(kFKDIEAJPCJ);
				NHKHKKFBDEN = kFKDIEAJPCJ;
				break;
			}
			}
		}
	}
}

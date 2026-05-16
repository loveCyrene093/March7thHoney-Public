using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FBJDFGMMMFP : IMessage<FBJDFGMMMFP>, IMessage, IEquatable<FBJDFGMMMFP>, IDeepCloneable<FBJDFGMMMFP>, IBufferMessage
{
	private static readonly MessageParser<FBJDFGMMMFP> _parser = new MessageParser<FBJDFGMMMFP>(() => new FBJDFGMMMFP());

	private UnknownFieldSet _unknownFields;

	public const int ReasonFieldNumber = 6;

	private GameplayCounterUpdateReason reason_;

	public const int NNBKPDKPIGIFieldNumber = 9;

	private uint nNBKPDKPIGI_;

	public const int IAPFBGEDGAMFieldNumber = 11;

	private uint iAPFBGEDGAM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FBJDFGMMMFP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FBJDFGMMMFPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameplayCounterUpdateReason Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NNBKPDKPIGI
	{
		get
		{
			return nNBKPDKPIGI_;
		}
		set
		{
			nNBKPDKPIGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IAPFBGEDGAM
	{
		get
		{
			return iAPFBGEDGAM_;
		}
		set
		{
			iAPFBGEDGAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBJDFGMMMFP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBJDFGMMMFP(FBJDFGMMMFP other)
		: this()
	{
		reason_ = other.reason_;
		nNBKPDKPIGI_ = other.nNBKPDKPIGI_;
		iAPFBGEDGAM_ = other.iAPFBGEDGAM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBJDFGMMMFP Clone()
	{
		return new FBJDFGMMMFP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FBJDFGMMMFP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FBJDFGMMMFP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (NNBKPDKPIGI != other.NNBKPDKPIGI)
		{
			return false;
		}
		if (IAPFBGEDGAM != other.IAPFBGEDGAM)
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
		if (Reason != GameplayCounterUpdateReason.None)
		{
			num ^= Reason.GetHashCode();
		}
		if (NNBKPDKPIGI != 0)
		{
			num ^= NNBKPDKPIGI.GetHashCode();
		}
		if (IAPFBGEDGAM != 0)
		{
			num ^= IAPFBGEDGAM.GetHashCode();
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
		if (Reason != GameplayCounterUpdateReason.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Reason);
		}
		if (NNBKPDKPIGI != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(NNBKPDKPIGI);
		}
		if (IAPFBGEDGAM != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(IAPFBGEDGAM);
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
		if (Reason != GameplayCounterUpdateReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (NNBKPDKPIGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NNBKPDKPIGI);
		}
		if (IAPFBGEDGAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IAPFBGEDGAM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FBJDFGMMMFP other)
	{
		if (other != null)
		{
			if (other.Reason != GameplayCounterUpdateReason.None)
			{
				Reason = other.Reason;
			}
			if (other.NNBKPDKPIGI != 0)
			{
				NNBKPDKPIGI = other.NNBKPDKPIGI;
			}
			if (other.IAPFBGEDGAM != 0)
			{
				IAPFBGEDGAM = other.IAPFBGEDGAM;
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
			case 48u:
				Reason = (GameplayCounterUpdateReason)input.ReadEnum();
				break;
			case 72u:
				NNBKPDKPIGI = input.ReadUInt32();
				break;
			case 88u:
				IAPFBGEDGAM = input.ReadUInt32();
				break;
			}
		}
	}
}

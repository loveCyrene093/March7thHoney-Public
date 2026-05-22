using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CounterRecoverCsReq : IMessage<CounterRecoverCsReq>, IMessage, IEquatable<CounterRecoverCsReq>, IDeepCloneable<CounterRecoverCsReq>, IBufferMessage
{
	private static readonly MessageParser<CounterRecoverCsReq> _parser = new MessageParser<CounterRecoverCsReq>(() => new CounterRecoverCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IAPFBGEDGAMFieldNumber = 11;

	private uint iAPFBGEDGAM_;

	public const int HNLADCMMJJAFieldNumber = 14;

	private uint hNLADCMMJJA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CounterRecoverCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CounterRecoverCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint HNLADCMMJJA
	{
		get
		{
			return hNLADCMMJJA_;
		}
		set
		{
			hNLADCMMJJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CounterRecoverCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CounterRecoverCsReq(CounterRecoverCsReq other)
		: this()
	{
		iAPFBGEDGAM_ = other.iAPFBGEDGAM_;
		hNLADCMMJJA_ = other.hNLADCMMJJA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CounterRecoverCsReq Clone()
	{
		return new CounterRecoverCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CounterRecoverCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CounterRecoverCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IAPFBGEDGAM != other.IAPFBGEDGAM)
		{
			return false;
		}
		if (HNLADCMMJJA != other.HNLADCMMJJA)
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
		if (IAPFBGEDGAM != 0)
		{
			num ^= IAPFBGEDGAM.GetHashCode();
		}
		if (HNLADCMMJJA != 0)
		{
			num ^= HNLADCMMJJA.GetHashCode();
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
		if (IAPFBGEDGAM != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(IAPFBGEDGAM);
		}
		if (HNLADCMMJJA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HNLADCMMJJA);
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
		if (IAPFBGEDGAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IAPFBGEDGAM);
		}
		if (HNLADCMMJJA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HNLADCMMJJA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CounterRecoverCsReq other)
	{
		if (other != null)
		{
			if (other.IAPFBGEDGAM != 0)
			{
				IAPFBGEDGAM = other.IAPFBGEDGAM;
			}
			if (other.HNLADCMMJJA != 0)
			{
				HNLADCMMJJA = other.HNLADCMMJJA;
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
			case 88u:
				IAPFBGEDGAM = input.ReadUInt32();
				break;
			case 112u:
				HNLADCMMJJA = input.ReadUInt32();
				break;
			}
		}
	}
}

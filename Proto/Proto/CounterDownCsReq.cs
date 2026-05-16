using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CounterDownCsReq : IMessage<CounterDownCsReq>, IMessage, IEquatable<CounterDownCsReq>, IDeepCloneable<CounterDownCsReq>, IBufferMessage
{
	private static readonly MessageParser<CounterDownCsReq> _parser = new MessageParser<CounterDownCsReq>(() => new CounterDownCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MEAJAEBDAOIFieldNumber = 1;

	private uint mEAJAEBDAOI_;

	public const int IAPFBGEDGAMFieldNumber = 14;

	private uint iAPFBGEDGAM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CounterDownCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CounterDownCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MEAJAEBDAOI
	{
		get
		{
			return mEAJAEBDAOI_;
		}
		set
		{
			mEAJAEBDAOI_ = value;
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
	public CounterDownCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CounterDownCsReq(CounterDownCsReq other)
		: this()
	{
		mEAJAEBDAOI_ = other.mEAJAEBDAOI_;
		iAPFBGEDGAM_ = other.iAPFBGEDGAM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CounterDownCsReq Clone()
	{
		return new CounterDownCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CounterDownCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CounterDownCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MEAJAEBDAOI != other.MEAJAEBDAOI)
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
		if (MEAJAEBDAOI != 0)
		{
			num ^= MEAJAEBDAOI.GetHashCode();
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
		if (MEAJAEBDAOI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MEAJAEBDAOI);
		}
		if (IAPFBGEDGAM != 0)
		{
			output.WriteRawTag(112);
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
		if (MEAJAEBDAOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MEAJAEBDAOI);
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
	public void MergeFrom(CounterDownCsReq other)
	{
		if (other != null)
		{
			if (other.MEAJAEBDAOI != 0)
			{
				MEAJAEBDAOI = other.MEAJAEBDAOI;
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
			case 8u:
				MEAJAEBDAOI = input.ReadUInt32();
				break;
			case 112u:
				IAPFBGEDGAM = input.ReadUInt32();
				break;
			}
		}
	}
}

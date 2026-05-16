using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LHPPIAKKFME : IMessage<LHPPIAKKFME>, IMessage, IEquatable<LHPPIAKKFME>, IDeepCloneable<LHPPIAKKFME>, IBufferMessage
{
	private static readonly MessageParser<LHPPIAKKFME> _parser = new MessageParser<LHPPIAKKFME>(() => new LHPPIAKKFME());

	private UnknownFieldSet _unknownFields;

	public const int BGKDAMDFFKHFieldNumber = 1;

	private GridFightDropType bGKDAMDFFKH_;

	public const int JJFFLMCCCMMFieldNumber = 2;

	private uint jJFFLMCCCMM_;

	public const int NumFieldNumber = 3;

	private uint num_;

	public const int DisplayValueFieldNumber = 5;

	private PKBBDFOOFJN displayValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LHPPIAKKFME> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LHPPIAKKFMEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDropType BGKDAMDFFKH
	{
		get
		{
			return bGKDAMDFFKH_;
		}
		set
		{
			bGKDAMDFFKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JJFFLMCCCMM
	{
		get
		{
			return jJFFLMCCCMM_;
		}
		set
		{
			jJFFLMCCCMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKBBDFOOFJN DisplayValue
	{
		get
		{
			return displayValue_;
		}
		set
		{
			displayValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHPPIAKKFME()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHPPIAKKFME(LHPPIAKKFME other)
		: this()
	{
		bGKDAMDFFKH_ = other.bGKDAMDFFKH_;
		jJFFLMCCCMM_ = other.jJFFLMCCCMM_;
		num_ = other.num_;
		displayValue_ = ((other.displayValue_ != null) ? other.displayValue_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHPPIAKKFME Clone()
	{
		return new LHPPIAKKFME(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LHPPIAKKFME);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LHPPIAKKFME other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BGKDAMDFFKH != other.BGKDAMDFFKH)
		{
			return false;
		}
		if (JJFFLMCCCMM != other.JJFFLMCCCMM)
		{
			return false;
		}
		if (Num != other.Num)
		{
			return false;
		}
		if (!object.Equals(DisplayValue, other.DisplayValue))
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
		if (BGKDAMDFFKH != GridFightDropType.HiolcnpoponPcpdhelpkem)
		{
			num ^= BGKDAMDFFKH.GetHashCode();
		}
		if (JJFFLMCCCMM != 0)
		{
			num ^= JJFFLMCCCMM.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (displayValue_ != null)
		{
			num ^= DisplayValue.GetHashCode();
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
		if (BGKDAMDFFKH != GridFightDropType.HiolcnpoponPcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)BGKDAMDFFKH);
		}
		if (JJFFLMCCCMM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JJFFLMCCCMM);
		}
		if (Num != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Num);
		}
		if (displayValue_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(DisplayValue);
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
		if (BGKDAMDFFKH != GridFightDropType.HiolcnpoponPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BGKDAMDFFKH);
		}
		if (JJFFLMCCCMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JJFFLMCCCMM);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Num);
		}
		if (displayValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DisplayValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LHPPIAKKFME other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BGKDAMDFFKH != GridFightDropType.HiolcnpoponPcpdhelpkem)
		{
			BGKDAMDFFKH = other.BGKDAMDFFKH;
		}
		if (other.JJFFLMCCCMM != 0)
		{
			JJFFLMCCCMM = other.JJFFLMCCCMM;
		}
		if (other.Num != 0)
		{
			Num = other.Num;
		}
		if (other.displayValue_ != null)
		{
			if (displayValue_ == null)
			{
				DisplayValue = new PKBBDFOOFJN();
			}
			DisplayValue.MergeFrom(other.DisplayValue);
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
			case 8u:
				BGKDAMDFFKH = (GridFightDropType)input.ReadEnum();
				break;
			case 16u:
				JJFFLMCCCMM = input.ReadUInt32();
				break;
			case 24u:
				Num = input.ReadUInt32();
				break;
			case 42u:
				if (displayValue_ == null)
				{
					DisplayValue = new PKBBDFOOFJN();
				}
				input.ReadMessage(DisplayValue);
				break;
			}
		}
	}
}

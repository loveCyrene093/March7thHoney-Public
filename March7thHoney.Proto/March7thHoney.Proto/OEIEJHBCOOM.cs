using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OEIEJHBCOOM : IMessage<OEIEJHBCOOM>, IMessage, IEquatable<OEIEJHBCOOM>, IDeepCloneable<OEIEJHBCOOM>, IBufferMessage
{
	private static readonly MessageParser<OEIEJHBCOOM> _parser = new MessageParser<OEIEJHBCOOM>(() => new OEIEJHBCOOM());

	private UnknownFieldSet _unknownFields;

	public const int MBOEFLAHLEMFieldNumber = 3;

	private uint mBOEFLAHLEM_;

	public const int PAPOKACIPPJFieldNumber = 9;

	private uint pAPOKACIPPJ_;

	public const int DGOMHDMJHEKFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_dGOMHDMJHEK_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> dGOMHDMJHEK_ = new RepeatedField<uint>();

	public const int IPLLMNPANIDFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_iPLLMNPANID_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> iPLLMNPANID_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OEIEJHBCOOM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OEIEJHBCOOMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MBOEFLAHLEM
	{
		get
		{
			return mBOEFLAHLEM_;
		}
		set
		{
			mBOEFLAHLEM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PAPOKACIPPJ
	{
		get
		{
			return pAPOKACIPPJ_;
		}
		set
		{
			pAPOKACIPPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DGOMHDMJHEK => dGOMHDMJHEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IPLLMNPANID => iPLLMNPANID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEIEJHBCOOM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEIEJHBCOOM(OEIEJHBCOOM other)
		: this()
	{
		mBOEFLAHLEM_ = other.mBOEFLAHLEM_;
		pAPOKACIPPJ_ = other.pAPOKACIPPJ_;
		dGOMHDMJHEK_ = other.dGOMHDMJHEK_.Clone();
		iPLLMNPANID_ = other.iPLLMNPANID_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEIEJHBCOOM Clone()
	{
		return new OEIEJHBCOOM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OEIEJHBCOOM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OEIEJHBCOOM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MBOEFLAHLEM != other.MBOEFLAHLEM)
		{
			return false;
		}
		if (PAPOKACIPPJ != other.PAPOKACIPPJ)
		{
			return false;
		}
		if (!dGOMHDMJHEK_.Equals(other.dGOMHDMJHEK_))
		{
			return false;
		}
		if (!iPLLMNPANID_.Equals(other.iPLLMNPANID_))
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
		if (MBOEFLAHLEM != 0)
		{
			num ^= MBOEFLAHLEM.GetHashCode();
		}
		if (PAPOKACIPPJ != 0)
		{
			num ^= PAPOKACIPPJ.GetHashCode();
		}
		num ^= dGOMHDMJHEK_.GetHashCode();
		num ^= iPLLMNPANID_.GetHashCode();
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
		if (MBOEFLAHLEM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MBOEFLAHLEM);
		}
		if (PAPOKACIPPJ != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PAPOKACIPPJ);
		}
		dGOMHDMJHEK_.WriteTo(ref output, _repeated_dGOMHDMJHEK_codec);
		iPLLMNPANID_.WriteTo(ref output, _repeated_iPLLMNPANID_codec);
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
		if (MBOEFLAHLEM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBOEFLAHLEM);
		}
		if (PAPOKACIPPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PAPOKACIPPJ);
		}
		num += dGOMHDMJHEK_.CalculateSize(_repeated_dGOMHDMJHEK_codec);
		num += iPLLMNPANID_.CalculateSize(_repeated_iPLLMNPANID_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OEIEJHBCOOM other)
	{
		if (other != null)
		{
			if (other.MBOEFLAHLEM != 0)
			{
				MBOEFLAHLEM = other.MBOEFLAHLEM;
			}
			if (other.PAPOKACIPPJ != 0)
			{
				PAPOKACIPPJ = other.PAPOKACIPPJ;
			}
			dGOMHDMJHEK_.Add(other.dGOMHDMJHEK_);
			iPLLMNPANID_.Add(other.iPLLMNPANID_);
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
			case 24u:
				MBOEFLAHLEM = input.ReadUInt32();
				break;
			case 72u:
				PAPOKACIPPJ = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				dGOMHDMJHEK_.AddEntriesFrom(ref input, _repeated_dGOMHDMJHEK_codec);
				break;
			case 120u:
			case 122u:
				iPLLMNPANID_.AddEntriesFrom(ref input, _repeated_iPLLMNPANID_codec);
				break;
			}
		}
	}
}

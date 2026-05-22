using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DrinkMakerCheersGetDataScRsp : IMessage<DrinkMakerCheersGetDataScRsp>, IMessage, IEquatable<DrinkMakerCheersGetDataScRsp>, IDeepCloneable<DrinkMakerCheersGetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<DrinkMakerCheersGetDataScRsp> _parser = new MessageParser<DrinkMakerCheersGetDataScRsp>(() => new DrinkMakerCheersGetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int HKEABJLEIPMFieldNumber = 3;

	private uint hKEABJLEIPM_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int EEDGBJFEECAFieldNumber = 8;

	private uint eEDGBJFEECA_;

	public const int MFEPAEKOPNNFieldNumber = 11;

	private static readonly FieldCodec<NCIFDEHCMBK> _repeated_mFEPAEKOPNN_codec = FieldCodec.ForMessage(90u, NCIFDEHCMBK.Parser);

	private readonly RepeatedField<NCIFDEHCMBK> mFEPAEKOPNN_ = new RepeatedField<NCIFDEHCMBK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DrinkMakerCheersGetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DrinkMakerCheersGetDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HKEABJLEIPM
	{
		get
		{
			return hKEABJLEIPM_;
		}
		set
		{
			hKEABJLEIPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EEDGBJFEECA
	{
		get
		{
			return eEDGBJFEECA_;
		}
		set
		{
			eEDGBJFEECA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NCIFDEHCMBK> MFEPAEKOPNN => mFEPAEKOPNN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerCheersGetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerCheersGetDataScRsp(DrinkMakerCheersGetDataScRsp other)
		: this()
	{
		hKEABJLEIPM_ = other.hKEABJLEIPM_;
		retcode_ = other.retcode_;
		eEDGBJFEECA_ = other.eEDGBJFEECA_;
		mFEPAEKOPNN_ = other.mFEPAEKOPNN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerCheersGetDataScRsp Clone()
	{
		return new DrinkMakerCheersGetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DrinkMakerCheersGetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DrinkMakerCheersGetDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HKEABJLEIPM != other.HKEABJLEIPM)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (EEDGBJFEECA != other.EEDGBJFEECA)
		{
			return false;
		}
		if (!mFEPAEKOPNN_.Equals(other.mFEPAEKOPNN_))
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
		if (HKEABJLEIPM != 0)
		{
			num ^= HKEABJLEIPM.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EEDGBJFEECA != 0)
		{
			num ^= EEDGBJFEECA.GetHashCode();
		}
		num ^= mFEPAEKOPNN_.GetHashCode();
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
		if (HKEABJLEIPM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HKEABJLEIPM);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (EEDGBJFEECA != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EEDGBJFEECA);
		}
		mFEPAEKOPNN_.WriteTo(ref output, _repeated_mFEPAEKOPNN_codec);
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
		if (HKEABJLEIPM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HKEABJLEIPM);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EEDGBJFEECA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EEDGBJFEECA);
		}
		num += mFEPAEKOPNN_.CalculateSize(_repeated_mFEPAEKOPNN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DrinkMakerCheersGetDataScRsp other)
	{
		if (other != null)
		{
			if (other.HKEABJLEIPM != 0)
			{
				HKEABJLEIPM = other.HKEABJLEIPM;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.EEDGBJFEECA != 0)
			{
				EEDGBJFEECA = other.EEDGBJFEECA;
			}
			mFEPAEKOPNN_.Add(other.mFEPAEKOPNN_);
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
				HKEABJLEIPM = input.ReadUInt32();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				EEDGBJFEECA = input.ReadUInt32();
				break;
			case 90u:
				mFEPAEKOPNN_.AddEntriesFrom(ref input, _repeated_mFEPAEKOPNN_codec);
				break;
			}
		}
	}
}

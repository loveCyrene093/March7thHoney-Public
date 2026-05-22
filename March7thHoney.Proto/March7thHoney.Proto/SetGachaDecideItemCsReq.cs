using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetGachaDecideItemCsReq : IMessage<SetGachaDecideItemCsReq>, IMessage, IEquatable<SetGachaDecideItemCsReq>, IDeepCloneable<SetGachaDecideItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetGachaDecideItemCsReq> _parser = new MessageParser<SetGachaDecideItemCsReq>(() => new SetGachaDecideItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GachaIdFieldNumber = 2;

	private uint gachaId_;

	public const int MBOEFLAHLEMFieldNumber = 4;

	private uint mBOEFLAHLEM_;

	public const int DGOMHDMJHEKFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_dGOMHDMJHEK_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> dGOMHDMJHEK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetGachaDecideItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetGachaDecideItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaId
	{
		get
		{
			return gachaId_;
		}
		set
		{
			gachaId_ = value;
		}
	}

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
	public RepeatedField<uint> DGOMHDMJHEK => dGOMHDMJHEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGachaDecideItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGachaDecideItemCsReq(SetGachaDecideItemCsReq other)
		: this()
	{
		gachaId_ = other.gachaId_;
		mBOEFLAHLEM_ = other.mBOEFLAHLEM_;
		dGOMHDMJHEK_ = other.dGOMHDMJHEK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGachaDecideItemCsReq Clone()
	{
		return new SetGachaDecideItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetGachaDecideItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetGachaDecideItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GachaId != other.GachaId)
		{
			return false;
		}
		if (MBOEFLAHLEM != other.MBOEFLAHLEM)
		{
			return false;
		}
		if (!dGOMHDMJHEK_.Equals(other.dGOMHDMJHEK_))
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
		if (GachaId != 0)
		{
			num ^= GachaId.GetHashCode();
		}
		if (MBOEFLAHLEM != 0)
		{
			num ^= MBOEFLAHLEM.GetHashCode();
		}
		num ^= dGOMHDMJHEK_.GetHashCode();
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
		if (GachaId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GachaId);
		}
		if (MBOEFLAHLEM != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MBOEFLAHLEM);
		}
		dGOMHDMJHEK_.WriteTo(ref output, _repeated_dGOMHDMJHEK_codec);
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
		if (GachaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaId);
		}
		if (MBOEFLAHLEM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBOEFLAHLEM);
		}
		num += dGOMHDMJHEK_.CalculateSize(_repeated_dGOMHDMJHEK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetGachaDecideItemCsReq other)
	{
		if (other != null)
		{
			if (other.GachaId != 0)
			{
				GachaId = other.GachaId;
			}
			if (other.MBOEFLAHLEM != 0)
			{
				MBOEFLAHLEM = other.MBOEFLAHLEM;
			}
			dGOMHDMJHEK_.Add(other.dGOMHDMJHEK_);
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
			case 16u:
				GachaId = input.ReadUInt32();
				break;
			case 32u:
				MBOEFLAHLEM = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				dGOMHDMJHEK_.AddEntriesFrom(ref input, _repeated_dGOMHDMJHEK_codec);
				break;
			}
		}
	}
}

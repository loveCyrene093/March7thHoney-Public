using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwordTrainingActionTurnSettleScNotify : IMessage<SwordTrainingActionTurnSettleScNotify>, IMessage, IEquatable<SwordTrainingActionTurnSettleScNotify>, IDeepCloneable<SwordTrainingActionTurnSettleScNotify>, IBufferMessage
{
	private static readonly MessageParser<SwordTrainingActionTurnSettleScNotify> _parser = new MessageParser<SwordTrainingActionTurnSettleScNotify>(() => new SwordTrainingActionTurnSettleScNotify());

	private UnknownFieldSet _unknownFields;

	public const int GBJFNGDMOKHFieldNumber = 6;

	private static readonly FieldCodec<BCICEMDDGEM> _repeated_gBJFNGDMOKH_codec = FieldCodec.ForMessage(50u, BCICEMDDGEM.Parser);

	private readonly RepeatedField<BCICEMDDGEM> gBJFNGDMOKH_ = new RepeatedField<BCICEMDDGEM>();

	public const int IGOHOHDKEJDFieldNumber = 15;

	private uint iGOHOHDKEJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwordTrainingActionTurnSettleScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwordTrainingActionTurnSettleScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BCICEMDDGEM> GBJFNGDMOKH => gBJFNGDMOKH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGOHOHDKEJD
	{
		get
		{
			return iGOHOHDKEJD_;
		}
		set
		{
			iGOHOHDKEJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingActionTurnSettleScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingActionTurnSettleScNotify(SwordTrainingActionTurnSettleScNotify other)
		: this()
	{
		gBJFNGDMOKH_ = other.gBJFNGDMOKH_.Clone();
		iGOHOHDKEJD_ = other.iGOHOHDKEJD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingActionTurnSettleScNotify Clone()
	{
		return new SwordTrainingActionTurnSettleScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwordTrainingActionTurnSettleScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwordTrainingActionTurnSettleScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gBJFNGDMOKH_.Equals(other.gBJFNGDMOKH_))
		{
			return false;
		}
		if (IGOHOHDKEJD != other.IGOHOHDKEJD)
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
		num ^= gBJFNGDMOKH_.GetHashCode();
		if (IGOHOHDKEJD != 0)
		{
			num ^= IGOHOHDKEJD.GetHashCode();
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
		gBJFNGDMOKH_.WriteTo(ref output, _repeated_gBJFNGDMOKH_codec);
		if (IGOHOHDKEJD != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(IGOHOHDKEJD);
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
		num += gBJFNGDMOKH_.CalculateSize(_repeated_gBJFNGDMOKH_codec);
		if (IGOHOHDKEJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGOHOHDKEJD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwordTrainingActionTurnSettleScNotify other)
	{
		if (other != null)
		{
			gBJFNGDMOKH_.Add(other.gBJFNGDMOKH_);
			if (other.IGOHOHDKEJD != 0)
			{
				IGOHOHDKEJD = other.IGOHOHDKEJD;
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
			case 50u:
				gBJFNGDMOKH_.AddEntriesFrom(ref input, _repeated_gBJFNGDMOKH_codec);
				break;
			case 120u:
				IGOHOHDKEJD = input.ReadUInt32();
				break;
			}
		}
	}
}

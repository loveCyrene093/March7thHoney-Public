using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KIPKNECKPHC : IMessage<KIPKNECKPHC>, IMessage, IEquatable<KIPKNECKPHC>, IDeepCloneable<KIPKNECKPHC>, IBufferMessage
{
	private static readonly MessageParser<KIPKNECKPHC> _parser = new MessageParser<KIPKNECKPHC>(() => new KIPKNECKPHC());

	private UnknownFieldSet _unknownFields;

	public const int BattleTargetListFieldNumber = 5;

	private static readonly FieldCodec<RogueAdventureRoomGameplayWolfGunTarget> _repeated_battleTargetList_codec = FieldCodec.ForMessage(42u, RogueAdventureRoomGameplayWolfGunTarget.Parser);

	private readonly RepeatedField<RogueAdventureRoomGameplayWolfGunTarget> battleTargetList_ = new RepeatedField<RogueAdventureRoomGameplayWolfGunTarget>();

	public const int AOBPFLEHBOHFieldNumber = 15;

	private uint aOBPFLEHBOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KIPKNECKPHC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KIPKNECKPHCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RogueAdventureRoomGameplayWolfGunTarget> BattleTargetList => battleTargetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOBPFLEHBOH
	{
		get
		{
			return aOBPFLEHBOH_;
		}
		set
		{
			aOBPFLEHBOH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIPKNECKPHC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIPKNECKPHC(KIPKNECKPHC other)
		: this()
	{
		battleTargetList_ = other.battleTargetList_.Clone();
		aOBPFLEHBOH_ = other.aOBPFLEHBOH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIPKNECKPHC Clone()
	{
		return new KIPKNECKPHC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KIPKNECKPHC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KIPKNECKPHC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!battleTargetList_.Equals(other.battleTargetList_))
		{
			return false;
		}
		if (AOBPFLEHBOH != other.AOBPFLEHBOH)
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
		num ^= battleTargetList_.GetHashCode();
		if (AOBPFLEHBOH != 0)
		{
			num ^= AOBPFLEHBOH.GetHashCode();
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
		battleTargetList_.WriteTo(ref output, _repeated_battleTargetList_codec);
		if (AOBPFLEHBOH != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(AOBPFLEHBOH);
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
		num += battleTargetList_.CalculateSize(_repeated_battleTargetList_codec);
		if (AOBPFLEHBOH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOBPFLEHBOH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KIPKNECKPHC other)
	{
		if (other != null)
		{
			battleTargetList_.Add(other.battleTargetList_);
			if (other.AOBPFLEHBOH != 0)
			{
				AOBPFLEHBOH = other.AOBPFLEHBOH;
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
			case 42u:
				battleTargetList_.AddEntriesFrom(ref input, _repeated_battleTargetList_codec);
				break;
			case 120u:
				AOBPFLEHBOH = input.ReadUInt32();
				break;
			}
		}
	}
}

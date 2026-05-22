using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneSummonUnitInfo : IMessage<SceneSummonUnitInfo>, IMessage, IEquatable<SceneSummonUnitInfo>, IDeepCloneable<SceneSummonUnitInfo>, IBufferMessage
{
	private static readonly MessageParser<SceneSummonUnitInfo> _parser = new MessageParser<SceneSummonUnitInfo>(() => new SceneSummonUnitInfo());

	private UnknownFieldSet _unknownFields;

	public const int SummonUnitIdFieldNumber = 15;

	private uint summonUnitId_;

	public const int TriggerNameListFieldNumber = 3;

	private static readonly FieldCodec<string> _repeated_triggerNameList_codec = FieldCodec.ForString(26u);

	private readonly RepeatedField<string> triggerNameList_ = new RepeatedField<string>();

	public const int CreateTimeMsFieldNumber = 5;

	private ulong createTimeMs_;

	public const int LifeTimeMsFieldNumber = 7;

	private int lifeTimeMs_;

	public const int AttachEntityIdFieldNumber = 8;

	private uint attachEntityId_;

	public const int CasterEntityIdFieldNumber = 1;

	private uint casterEntityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneSummonUnitInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneSummonUnitInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SummonUnitId
	{
		get
		{
			return summonUnitId_;
		}
		set
		{
			summonUnitId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> TriggerNameList => triggerNameList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong CreateTimeMs
	{
		get
		{
			return createTimeMs_;
		}
		set
		{
			createTimeMs_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LifeTimeMs
	{
		get
		{
			return lifeTimeMs_;
		}
		set
		{
			lifeTimeMs_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AttachEntityId
	{
		get
		{
			return attachEntityId_;
		}
		set
		{
			attachEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CasterEntityId
	{
		get
		{
			return casterEntityId_;
		}
		set
		{
			casterEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneSummonUnitInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneSummonUnitInfo(SceneSummonUnitInfo other)
		: this()
	{
		summonUnitId_ = other.summonUnitId_;
		triggerNameList_ = other.triggerNameList_.Clone();
		createTimeMs_ = other.createTimeMs_;
		lifeTimeMs_ = other.lifeTimeMs_;
		attachEntityId_ = other.attachEntityId_;
		casterEntityId_ = other.casterEntityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneSummonUnitInfo Clone()
	{
		return new SceneSummonUnitInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneSummonUnitInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneSummonUnitInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SummonUnitId != other.SummonUnitId)
		{
			return false;
		}
		if (!triggerNameList_.Equals(other.triggerNameList_))
		{
			return false;
		}
		if (CreateTimeMs != other.CreateTimeMs)
		{
			return false;
		}
		if (LifeTimeMs != other.LifeTimeMs)
		{
			return false;
		}
		if (AttachEntityId != other.AttachEntityId)
		{
			return false;
		}
		if (CasterEntityId != other.CasterEntityId)
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
		if (SummonUnitId != 0)
		{
			num ^= SummonUnitId.GetHashCode();
		}
		num ^= triggerNameList_.GetHashCode();
		if (CreateTimeMs != 0L)
		{
			num ^= CreateTimeMs.GetHashCode();
		}
		if (LifeTimeMs != 0)
		{
			num ^= LifeTimeMs.GetHashCode();
		}
		if (AttachEntityId != 0)
		{
			num ^= AttachEntityId.GetHashCode();
		}
		if (CasterEntityId != 0)
		{
			num ^= CasterEntityId.GetHashCode();
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
		if (SummonUnitId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(SummonUnitId);
		}
		triggerNameList_.WriteTo(ref output, _repeated_triggerNameList_codec);
		if (CreateTimeMs != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(CreateTimeMs);
		}
		if (LifeTimeMs != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(LifeTimeMs);
		}
		if (AttachEntityId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(AttachEntityId);
		}
		if (CasterEntityId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CasterEntityId);
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
		if (SummonUnitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SummonUnitId);
		}
		num += triggerNameList_.CalculateSize(_repeated_triggerNameList_codec);
		if (CreateTimeMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CreateTimeMs);
		}
		if (LifeTimeMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LifeTimeMs);
		}
		if (AttachEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AttachEntityId);
		}
		if (CasterEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CasterEntityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneSummonUnitInfo other)
	{
		if (other != null)
		{
			if (other.SummonUnitId != 0)
			{
				SummonUnitId = other.SummonUnitId;
			}
			triggerNameList_.Add(other.triggerNameList_);
			if (other.CreateTimeMs != 0L)
			{
				CreateTimeMs = other.CreateTimeMs;
			}
			if (other.LifeTimeMs != 0)
			{
				LifeTimeMs = other.LifeTimeMs;
			}
			if (other.AttachEntityId != 0)
			{
				AttachEntityId = other.AttachEntityId;
			}
			if (other.CasterEntityId != 0)
			{
				CasterEntityId = other.CasterEntityId;
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
				CasterEntityId = input.ReadUInt32();
				break;
			case 26u:
				triggerNameList_.AddEntriesFrom(ref input, _repeated_triggerNameList_codec);
				break;
			case 40u:
				CreateTimeMs = input.ReadUInt64();
				break;
			case 56u:
				LifeTimeMs = input.ReadInt32();
				break;
			case 64u:
				AttachEntityId = input.ReadUInt32();
				break;
			case 120u:
				SummonUnitId = input.ReadUInt32();
				break;
			}
		}
	}
}

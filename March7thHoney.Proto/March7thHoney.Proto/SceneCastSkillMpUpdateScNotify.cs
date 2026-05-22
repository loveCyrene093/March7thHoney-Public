using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneCastSkillMpUpdateScNotify : IMessage<SceneCastSkillMpUpdateScNotify>, IMessage, IEquatable<SceneCastSkillMpUpdateScNotify>, IDeepCloneable<SceneCastSkillMpUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<SceneCastSkillMpUpdateScNotify> _parser = new MessageParser<SceneCastSkillMpUpdateScNotify>(() => new SceneCastSkillMpUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CastEntityIdFieldNumber = 3;

	private uint castEntityId_;

	public const int MpFieldNumber = 9;

	private uint mp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneCastSkillMpUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneCastSkillMpUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CastEntityId
	{
		get
		{
			return castEntityId_;
		}
		set
		{
			castEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Mp
	{
		get
		{
			return mp_;
		}
		set
		{
			mp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillMpUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillMpUpdateScNotify(SceneCastSkillMpUpdateScNotify other)
		: this()
	{
		castEntityId_ = other.castEntityId_;
		mp_ = other.mp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillMpUpdateScNotify Clone()
	{
		return new SceneCastSkillMpUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneCastSkillMpUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneCastSkillMpUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CastEntityId != other.CastEntityId)
		{
			return false;
		}
		if (Mp != other.Mp)
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
		if (CastEntityId != 0)
		{
			num ^= CastEntityId.GetHashCode();
		}
		if (Mp != 0)
		{
			num ^= Mp.GetHashCode();
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
		if (CastEntityId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CastEntityId);
		}
		if (Mp != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Mp);
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
		if (CastEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CastEntityId);
		}
		if (Mp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Mp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneCastSkillMpUpdateScNotify other)
	{
		if (other != null)
		{
			if (other.CastEntityId != 0)
			{
				CastEntityId = other.CastEntityId;
			}
			if (other.Mp != 0)
			{
				Mp = other.Mp;
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
			case 24u:
				CastEntityId = input.ReadUInt32();
				break;
			case 72u:
				Mp = input.ReadUInt32();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneEntityMoveCsReq : IMessage<SceneEntityMoveCsReq>, IMessage, IEquatable<SceneEntityMoveCsReq>, IDeepCloneable<SceneEntityMoveCsReq>, IBufferMessage
{
	private static readonly MessageParser<SceneEntityMoveCsReq> _parser = new MessageParser<SceneEntityMoveCsReq>(() => new SceneEntityMoveCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EntryIdFieldNumber = 3;

	private uint entryId_;

	public const int InteractIdFieldNumber = 6;

	private ulong interactId_;

	public const int EntityMotionListFieldNumber = 10;

	private static readonly FieldCodec<EntityMotion> _repeated_entityMotionList_codec = FieldCodec.ForMessage(82u, EntityMotion.Parser);

	private readonly RepeatedField<EntityMotion> entityMotionList_ = new RepeatedField<EntityMotion>();

	public const int BFBEHMAFJMCFieldNumber = 13;

	private ulong bFBEHMAFJMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneEntityMoveCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneEntityMoveCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntryId
	{
		get
		{
			return entryId_;
		}
		set
		{
			entryId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EntityMotion> EntityMotionList => entityMotionList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong BFBEHMAFJMC
	{
		get
		{
			return bFBEHMAFJMC_;
		}
		set
		{
			bFBEHMAFJMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityMoveCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityMoveCsReq(SceneEntityMoveCsReq other)
		: this()
	{
		entryId_ = other.entryId_;
		interactId_ = other.interactId_;
		entityMotionList_ = other.entityMotionList_.Clone();
		bFBEHMAFJMC_ = other.bFBEHMAFJMC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityMoveCsReq Clone()
	{
		return new SceneEntityMoveCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneEntityMoveCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneEntityMoveCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EntryId != other.EntryId)
		{
			return false;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (!entityMotionList_.Equals(other.entityMotionList_))
		{
			return false;
		}
		if (BFBEHMAFJMC != other.BFBEHMAFJMC)
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
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
		}
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
		}
		num ^= entityMotionList_.GetHashCode();
		if (BFBEHMAFJMC != 0L)
		{
			num ^= BFBEHMAFJMC.GetHashCode();
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
		if (EntryId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EntryId);
		}
		if (InteractId != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(InteractId);
		}
		entityMotionList_.WriteTo(ref output, _repeated_entityMotionList_codec);
		if (BFBEHMAFJMC != 0L)
		{
			output.WriteRawTag(104);
			output.WriteUInt64(BFBEHMAFJMC);
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
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		num += entityMotionList_.CalculateSize(_repeated_entityMotionList_codec);
		if (BFBEHMAFJMC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(BFBEHMAFJMC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneEntityMoveCsReq other)
	{
		if (other != null)
		{
			if (other.EntryId != 0)
			{
				EntryId = other.EntryId;
			}
			if (other.InteractId != 0L)
			{
				InteractId = other.InteractId;
			}
			entityMotionList_.Add(other.entityMotionList_);
			if (other.BFBEHMAFJMC != 0L)
			{
				BFBEHMAFJMC = other.BFBEHMAFJMC;
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
				EntryId = input.ReadUInt32();
				break;
			case 48u:
				InteractId = input.ReadUInt64();
				break;
			case 82u:
				entityMotionList_.AddEntriesFrom(ref input, _repeated_entityMotionList_codec);
				break;
			case 104u:
				BFBEHMAFJMC = input.ReadUInt64();
				break;
			}
		}
	}
}

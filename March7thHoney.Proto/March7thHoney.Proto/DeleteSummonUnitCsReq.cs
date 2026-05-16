using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DeleteSummonUnitCsReq : IMessage<DeleteSummonUnitCsReq>, IMessage, IEquatable<DeleteSummonUnitCsReq>, IDeepCloneable<DeleteSummonUnitCsReq>, IBufferMessage
{
	private static readonly MessageParser<DeleteSummonUnitCsReq> _parser = new MessageParser<DeleteSummonUnitCsReq>(() => new DeleteSummonUnitCsReq());

	private UnknownFieldSet _unknownFields;

	public const int InteractIdFieldNumber = 6;

	private ulong interactId_;

	public const int EntityIdListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_entityIdList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> entityIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DeleteSummonUnitCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DeleteSummonUnitCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<uint> EntityIdList => entityIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteSummonUnitCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteSummonUnitCsReq(DeleteSummonUnitCsReq other)
		: this()
	{
		interactId_ = other.interactId_;
		entityIdList_ = other.entityIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteSummonUnitCsReq Clone()
	{
		return new DeleteSummonUnitCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DeleteSummonUnitCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DeleteSummonUnitCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (!entityIdList_.Equals(other.entityIdList_))
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
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
		}
		num ^= entityIdList_.GetHashCode();
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
		if (InteractId != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(InteractId);
		}
		entityIdList_.WriteTo(ref output, _repeated_entityIdList_codec);
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
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		num += entityIdList_.CalculateSize(_repeated_entityIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DeleteSummonUnitCsReq other)
	{
		if (other != null)
		{
			if (other.InteractId != 0L)
			{
				InteractId = other.InteractId;
			}
			entityIdList_.Add(other.entityIdList_);
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
			case 48u:
				InteractId = input.ReadUInt64();
				break;
			case 72u:
			case 74u:
				entityIdList_.AddEntriesFrom(ref input, _repeated_entityIdList_codec);
				break;
			}
		}
	}
}

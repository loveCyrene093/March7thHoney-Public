using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateGroupPropertyCsReq : IMessage<UpdateGroupPropertyCsReq>, IMessage, IEquatable<UpdateGroupPropertyCsReq>, IDeepCloneable<UpdateGroupPropertyCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpdateGroupPropertyCsReq> _parser = new MessageParser<UpdateGroupPropertyCsReq>(() => new UpdateGroupPropertyCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DimensionIdFieldNumber = 4;

	private uint dimensionId_;

	public const int AOBABOGHFKJFieldNumber = 5;

	private int aOBABOGHFKJ_;

	public const int GroupIdFieldNumber = 6;

	private uint groupId_;

	public const int ELNCJFFJFIHFieldNumber = 7;

	private string eLNCJFFJFIH_ = "";

	public const int InteractIdFieldNumber = 12;

	private ulong interactId_;

	public const int FloorIdFieldNumber = 15;

	private uint floorId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateGroupPropertyCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateGroupPropertyCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DimensionId
	{
		get
		{
			return dimensionId_;
		}
		set
		{
			dimensionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AOBABOGHFKJ
	{
		get
		{
			return aOBABOGHFKJ_;
		}
		set
		{
			aOBABOGHFKJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ELNCJFFJFIH
	{
		get
		{
			return eLNCJFFJFIH_;
		}
		set
		{
			eLNCJFFJFIH_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public uint FloorId
	{
		get
		{
			return floorId_;
		}
		set
		{
			floorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateGroupPropertyCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateGroupPropertyCsReq(UpdateGroupPropertyCsReq other)
		: this()
	{
		dimensionId_ = other.dimensionId_;
		aOBABOGHFKJ_ = other.aOBABOGHFKJ_;
		groupId_ = other.groupId_;
		eLNCJFFJFIH_ = other.eLNCJFFJFIH_;
		interactId_ = other.interactId_;
		floorId_ = other.floorId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateGroupPropertyCsReq Clone()
	{
		return new UpdateGroupPropertyCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateGroupPropertyCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateGroupPropertyCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DimensionId != other.DimensionId)
		{
			return false;
		}
		if (AOBABOGHFKJ != other.AOBABOGHFKJ)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (ELNCJFFJFIH != other.ELNCJFFJFIH)
		{
			return false;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (FloorId != other.FloorId)
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
		if (DimensionId != 0)
		{
			num ^= DimensionId.GetHashCode();
		}
		if (AOBABOGHFKJ != 0)
		{
			num ^= AOBABOGHFKJ.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (ELNCJFFJFIH.Length != 0)
		{
			num ^= ELNCJFFJFIH.GetHashCode();
		}
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
		}
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
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
		if (DimensionId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DimensionId);
		}
		if (AOBABOGHFKJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(AOBABOGHFKJ);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GroupId);
		}
		if (ELNCJFFJFIH.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(ELNCJFFJFIH);
		}
		if (InteractId != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(InteractId);
		}
		if (FloorId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FloorId);
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
		if (DimensionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DimensionId);
		}
		if (AOBABOGHFKJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AOBABOGHFKJ);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (ELNCJFFJFIH.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ELNCJFFJFIH);
		}
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateGroupPropertyCsReq other)
	{
		if (other != null)
		{
			if (other.DimensionId != 0)
			{
				DimensionId = other.DimensionId;
			}
			if (other.AOBABOGHFKJ != 0)
			{
				AOBABOGHFKJ = other.AOBABOGHFKJ;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.ELNCJFFJFIH.Length != 0)
			{
				ELNCJFFJFIH = other.ELNCJFFJFIH;
			}
			if (other.InteractId != 0L)
			{
				InteractId = other.InteractId;
			}
			if (other.FloorId != 0)
			{
				FloorId = other.FloorId;
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
			case 32u:
				DimensionId = input.ReadUInt32();
				break;
			case 40u:
				AOBABOGHFKJ = input.ReadInt32();
				break;
			case 48u:
				GroupId = input.ReadUInt32();
				break;
			case 58u:
				ELNCJFFJFIH = input.ReadString();
				break;
			case 96u:
				InteractId = input.ReadUInt64();
				break;
			case 120u:
				FloorId = input.ReadUInt32();
				break;
			}
		}
	}
}

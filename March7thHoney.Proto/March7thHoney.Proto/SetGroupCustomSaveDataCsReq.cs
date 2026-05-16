using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetGroupCustomSaveDataCsReq : IMessage<SetGroupCustomSaveDataCsReq>, IMessage, IEquatable<SetGroupCustomSaveDataCsReq>, IDeepCloneable<SetGroupCustomSaveDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetGroupCustomSaveDataCsReq> _parser = new MessageParser<SetGroupCustomSaveDataCsReq>(() => new SetGroupCustomSaveDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int SaveDataFieldNumber = 8;

	private string saveData_ = "";

	public const int EntryIdFieldNumber = 9;

	private uint entryId_;

	public const int InteractIdFieldNumber = 12;

	private ulong interactId_;

	public const int GroupIdFieldNumber = 14;

	private uint groupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetGroupCustomSaveDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetGroupCustomSaveDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SaveData
	{
		get
		{
			return saveData_;
		}
		set
		{
			saveData_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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
	public SetGroupCustomSaveDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGroupCustomSaveDataCsReq(SetGroupCustomSaveDataCsReq other)
		: this()
	{
		saveData_ = other.saveData_;
		entryId_ = other.entryId_;
		interactId_ = other.interactId_;
		groupId_ = other.groupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGroupCustomSaveDataCsReq Clone()
	{
		return new SetGroupCustomSaveDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetGroupCustomSaveDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetGroupCustomSaveDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SaveData != other.SaveData)
		{
			return false;
		}
		if (EntryId != other.EntryId)
		{
			return false;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (GroupId != other.GroupId)
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
		if (SaveData.Length != 0)
		{
			num ^= SaveData.GetHashCode();
		}
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
		}
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
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
		if (SaveData.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(SaveData);
		}
		if (EntryId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EntryId);
		}
		if (InteractId != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(InteractId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GroupId);
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
		if (SaveData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SaveData);
		}
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetGroupCustomSaveDataCsReq other)
	{
		if (other != null)
		{
			if (other.SaveData.Length != 0)
			{
				SaveData = other.SaveData;
			}
			if (other.EntryId != 0)
			{
				EntryId = other.EntryId;
			}
			if (other.InteractId != 0L)
			{
				InteractId = other.InteractId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
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
			case 66u:
				SaveData = input.ReadString();
				break;
			case 72u:
				EntryId = input.ReadUInt32();
				break;
			case 96u:
				InteractId = input.ReadUInt64();
				break;
			case 112u:
				GroupId = input.ReadUInt32();
				break;
			}
		}
	}
}

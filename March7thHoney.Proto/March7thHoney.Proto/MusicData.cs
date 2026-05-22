using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MusicData : IMessage<MusicData>, IMessage, IEquatable<MusicData>, IDeepCloneable<MusicData>, IBufferMessage
{
	private static readonly MessageParser<MusicData> _parser = new MessageParser<MusicData>(() => new MusicData());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 8;

	private uint id_;

	public const int IsPlayedFieldNumber = 10;

	private bool isPlayed_;

	public const int GroupIdFieldNumber = 15;

	private uint groupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MusicData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MusicDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsPlayed
	{
		get
		{
			return isPlayed_;
		}
		set
		{
			isPlayed_ = value;
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
	public MusicData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicData(MusicData other)
		: this()
	{
		id_ = other.id_;
		isPlayed_ = other.isPlayed_;
		groupId_ = other.groupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicData Clone()
	{
		return new MusicData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MusicData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MusicData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (IsPlayed != other.IsPlayed)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsPlayed)
		{
			num ^= IsPlayed.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Id);
		}
		if (IsPlayed)
		{
			output.WriteRawTag(80);
			output.WriteBool(IsPlayed);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(120);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (IsPlayed)
		{
			num += 2;
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
	public void MergeFrom(MusicData other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsPlayed)
			{
				IsPlayed = other.IsPlayed;
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
			case 64u:
				Id = input.ReadUInt32();
				break;
			case 80u:
				IsPlayed = input.ReadBool();
				break;
			case 120u:
				GroupId = input.ReadUInt32();
				break;
			}
		}
	}
}

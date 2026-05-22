using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GroupStateChangeScNotify : IMessage<GroupStateChangeScNotify>, IMessage, IEquatable<GroupStateChangeScNotify>, IDeepCloneable<GroupStateChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<GroupStateChangeScNotify> _parser = new MessageParser<GroupStateChangeScNotify>(() => new GroupStateChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int GroupStateInfoFieldNumber = 4;

	private GroupStateInfo groupStateInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GroupStateChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GroupStateChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStateInfo GroupStateInfo
	{
		get
		{
			return groupStateInfo_;
		}
		set
		{
			groupStateInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStateChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStateChangeScNotify(GroupStateChangeScNotify other)
		: this()
	{
		groupStateInfo_ = ((other.groupStateInfo_ != null) ? other.groupStateInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStateChangeScNotify Clone()
	{
		return new GroupStateChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GroupStateChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GroupStateChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GroupStateInfo, other.GroupStateInfo))
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
		if (groupStateInfo_ != null)
		{
			num ^= GroupStateInfo.GetHashCode();
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
		if (groupStateInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(GroupStateInfo);
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
		if (groupStateInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GroupStateInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GroupStateChangeScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.groupStateInfo_ != null)
		{
			if (groupStateInfo_ == null)
			{
				GroupStateInfo = new GroupStateInfo();
			}
			GroupStateInfo.MergeFrom(other.GroupStateInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (groupStateInfo_ == null)
			{
				GroupStateInfo = new GroupStateInfo();
			}
			input.ReadMessage(GroupStateInfo);
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GroupStateChangeCsReq : IMessage<GroupStateChangeCsReq>, IMessage, IEquatable<GroupStateChangeCsReq>, IDeepCloneable<GroupStateChangeCsReq>, IBufferMessage
{
	private static readonly MessageParser<GroupStateChangeCsReq> _parser = new MessageParser<GroupStateChangeCsReq>(() => new GroupStateChangeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int InteractIdFieldNumber = 1;

	private ulong interactId_;

	public const int GroupStateInfoFieldNumber = 11;

	private GroupStateInfo groupStateInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GroupStateChangeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GroupStateChangeCsReqReflection.Descriptor.MessageTypes[0];

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
	public GroupStateChangeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStateChangeCsReq(GroupStateChangeCsReq other)
		: this()
	{
		interactId_ = other.interactId_;
		groupStateInfo_ = ((other.groupStateInfo_ != null) ? other.groupStateInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStateChangeCsReq Clone()
	{
		return new GroupStateChangeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GroupStateChangeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GroupStateChangeCsReq other)
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
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
		}
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
		if (InteractId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(InteractId);
		}
		if (groupStateInfo_ != null)
		{
			output.WriteRawTag(90);
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
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
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
	public void MergeFrom(GroupStateChangeCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.InteractId != 0L)
		{
			InteractId = other.InteractId;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				InteractId = input.ReadUInt64();
				break;
			case 90u:
				if (groupStateInfo_ == null)
				{
					GroupStateInfo = new GroupStateInfo();
				}
				input.ReadMessage(GroupStateInfo);
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StarFightDataChangeNotify : IMessage<StarFightDataChangeNotify>, IMessage, IEquatable<StarFightDataChangeNotify>, IDeepCloneable<StarFightDataChangeNotify>, IBufferMessage
{
	private static readonly MessageParser<StarFightDataChangeNotify> _parser = new MessageParser<StarFightDataChangeNotify>(() => new StarFightDataChangeNotify());

	private UnknownFieldSet _unknownFields;

	public const int GKHINECAFHNFieldNumber = 5;

	private EAKBDLAEKHJ gKHINECAFHN_;

	public const int GroupIdFieldNumber = 12;

	private uint groupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StarFightDataChangeNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StarFightDataChangeNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EAKBDLAEKHJ GKHINECAFHN
	{
		get
		{
			return gKHINECAFHN_;
		}
		set
		{
			gKHINECAFHN_ = value;
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
	public StarFightDataChangeNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StarFightDataChangeNotify(StarFightDataChangeNotify other)
		: this()
	{
		gKHINECAFHN_ = ((other.gKHINECAFHN_ != null) ? other.gKHINECAFHN_.Clone() : null);
		groupId_ = other.groupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StarFightDataChangeNotify Clone()
	{
		return new StarFightDataChangeNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StarFightDataChangeNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StarFightDataChangeNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GKHINECAFHN, other.GKHINECAFHN))
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
		if (gKHINECAFHN_ != null)
		{
			num ^= GKHINECAFHN.GetHashCode();
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
		if (gKHINECAFHN_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(GKHINECAFHN);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(96);
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
		if (gKHINECAFHN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GKHINECAFHN);
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
	public void MergeFrom(StarFightDataChangeNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gKHINECAFHN_ != null)
		{
			if (gKHINECAFHN_ == null)
			{
				GKHINECAFHN = new EAKBDLAEKHJ();
			}
			GKHINECAFHN.MergeFrom(other.GKHINECAFHN);
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
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
			case 42u:
				if (gKHINECAFHN_ == null)
				{
					GKHINECAFHN = new EAKBDLAEKHJ();
				}
				input.ReadMessage(GKHINECAFHN);
				break;
			case 96u:
				GroupId = input.ReadUInt32();
				break;
			}
		}
	}
}

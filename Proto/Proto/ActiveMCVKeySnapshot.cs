using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActiveMCVKeySnapshot : IMessage<ActiveMCVKeySnapshot>, IMessage, IEquatable<ActiveMCVKeySnapshot>, IDeepCloneable<ActiveMCVKeySnapshot>, IBufferMessage
{
	private static readonly MessageParser<ActiveMCVKeySnapshot> _parser = new MessageParser<ActiveMCVKeySnapshot>(() => new ActiveMCVKeySnapshot());

	private UnknownFieldSet _unknownFields;

	public const int MainMissionIdFieldNumber = 1;

	private uint mainMissionId_;

	public const int McvKeyFieldNumber = 2;

	private string mcvKey_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ActiveMCVKeySnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ActiveMCVKeySnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MainMissionId
	{
		get
		{
			return mainMissionId_;
		}
		set
		{
			mainMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string McvKey
	{
		get
		{
			return mcvKey_;
		}
		set
		{
			mcvKey_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActiveMCVKeySnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActiveMCVKeySnapshot(ActiveMCVKeySnapshot other)
		: this()
	{
		mainMissionId_ = other.mainMissionId_;
		mcvKey_ = other.mcvKey_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActiveMCVKeySnapshot Clone()
	{
		return new ActiveMCVKeySnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ActiveMCVKeySnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ActiveMCVKeySnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MainMissionId != other.MainMissionId)
		{
			return false;
		}
		if (McvKey != other.McvKey)
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
		if (MainMissionId != 0)
		{
			num ^= MainMissionId.GetHashCode();
		}
		if (McvKey.Length != 0)
		{
			num ^= McvKey.GetHashCode();
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
		if (MainMissionId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MainMissionId);
		}
		if (McvKey.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(McvKey);
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
		if (MainMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainMissionId);
		}
		if (McvKey.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(McvKey);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ActiveMCVKeySnapshot other)
	{
		if (other != null)
		{
			if (other.MainMissionId != 0)
			{
				MainMissionId = other.MainMissionId;
			}
			if (other.McvKey.Length != 0)
			{
				McvKey = other.McvKey;
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
				MainMissionId = input.ReadUInt32();
				break;
			case 18u:
				McvKey = input.ReadString();
				break;
			}
		}
	}
}

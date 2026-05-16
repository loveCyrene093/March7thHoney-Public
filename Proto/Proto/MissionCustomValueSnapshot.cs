using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MissionCustomValueSnapshot : IMessage<MissionCustomValueSnapshot>, IMessage, IEquatable<MissionCustomValueSnapshot>, IDeepCloneable<MissionCustomValueSnapshot>, IBufferMessage
{
	private static readonly MessageParser<MissionCustomValueSnapshot> _parser = new MessageParser<MissionCustomValueSnapshot>(() => new MissionCustomValueSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int CustomValueFieldNumber = 1;

	private uint customValue_;

	public const int McvKeyFieldNumber = 2;

	private string mcvKey_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MissionCustomValueSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MissionCustomValueSnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CustomValue
	{
		get
		{
			return customValue_;
		}
		set
		{
			customValue_ = value;
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
	public MissionCustomValueSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionCustomValueSnapshot(MissionCustomValueSnapshot other)
		: this()
	{
		customValue_ = other.customValue_;
		mcvKey_ = other.mcvKey_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionCustomValueSnapshot Clone()
	{
		return new MissionCustomValueSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MissionCustomValueSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MissionCustomValueSnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CustomValue != other.CustomValue)
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
		if (CustomValue != 0)
		{
			num ^= CustomValue.GetHashCode();
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
		if (CustomValue != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CustomValue);
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
		if (CustomValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CustomValue);
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
	public void MergeFrom(MissionCustomValueSnapshot other)
	{
		if (other != null)
		{
			if (other.CustomValue != 0)
			{
				CustomValue = other.CustomValue;
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
				CustomValue = input.ReadUInt32();
				break;
			case 18u:
				McvKey = input.ReadString();
				break;
			}
		}
	}
}

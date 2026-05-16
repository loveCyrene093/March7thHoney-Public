using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcDialogueEventParam : IMessage<NpcDialogueEventParam>, IMessage, IEquatable<NpcDialogueEventParam>, IDeepCloneable<NpcDialogueEventParam>, IBufferMessage
{
	private static readonly MessageParser<NpcDialogueEventParam> _parser = new MessageParser<NpcDialogueEventParam>(() => new NpcDialogueEventParam());

	private UnknownFieldSet _unknownFields;

	public const int ArgIdFieldNumber = 9;

	private uint argId_;

	public const int RogueDialogueEventIdFieldNumber = 11;

	private uint rogueDialogueEventId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NpcDialogueEventParam> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NpcDialogueEventParamReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ArgId
	{
		get
		{
			return argId_;
		}
		set
		{
			argId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RogueDialogueEventId
	{
		get
		{
			return rogueDialogueEventId_;
		}
		set
		{
			rogueDialogueEventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcDialogueEventParam()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcDialogueEventParam(NpcDialogueEventParam other)
		: this()
	{
		argId_ = other.argId_;
		rogueDialogueEventId_ = other.rogueDialogueEventId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcDialogueEventParam Clone()
	{
		return new NpcDialogueEventParam(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NpcDialogueEventParam);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NpcDialogueEventParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ArgId != other.ArgId)
		{
			return false;
		}
		if (RogueDialogueEventId != other.RogueDialogueEventId)
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
		if (ArgId != 0)
		{
			num ^= ArgId.GetHashCode();
		}
		if (RogueDialogueEventId != 0)
		{
			num ^= RogueDialogueEventId.GetHashCode();
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
		if (ArgId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ArgId);
		}
		if (RogueDialogueEventId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(RogueDialogueEventId);
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
		if (ArgId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ArgId);
		}
		if (RogueDialogueEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RogueDialogueEventId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NpcDialogueEventParam other)
	{
		if (other != null)
		{
			if (other.ArgId != 0)
			{
				ArgId = other.ArgId;
			}
			if (other.RogueDialogueEventId != 0)
			{
				RogueDialogueEventId = other.RogueDialogueEventId;
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
			case 72u:
				ArgId = input.ReadUInt32();
				break;
			case 88u:
				RogueDialogueEventId = input.ReadUInt32();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncChessRogueNousSubStoryScNotify : IMessage<SyncChessRogueNousSubStoryScNotify>, IMessage, IEquatable<SyncChessRogueNousSubStoryScNotify>, IDeepCloneable<SyncChessRogueNousSubStoryScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncChessRogueNousSubStoryScNotify> _parser = new MessageParser<SyncChessRogueNousSubStoryScNotify>(() => new SyncChessRogueNousSubStoryScNotify());

	private UnknownFieldSet _unknownFields;

	public const int IENBKIAGPBAFieldNumber = 1;

	private uint iENBKIAGPBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncChessRogueNousSubStoryScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncChessRogueNousSubStoryScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IENBKIAGPBA
	{
		get
		{
			return iENBKIAGPBA_;
		}
		set
		{
			iENBKIAGPBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueNousSubStoryScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueNousSubStoryScNotify(SyncChessRogueNousSubStoryScNotify other)
		: this()
	{
		iENBKIAGPBA_ = other.iENBKIAGPBA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueNousSubStoryScNotify Clone()
	{
		return new SyncChessRogueNousSubStoryScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncChessRogueNousSubStoryScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncChessRogueNousSubStoryScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IENBKIAGPBA != other.IENBKIAGPBA)
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
		if (IENBKIAGPBA != 0)
		{
			num ^= IENBKIAGPBA.GetHashCode();
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
		if (IENBKIAGPBA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IENBKIAGPBA);
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
		if (IENBKIAGPBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IENBKIAGPBA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncChessRogueNousSubStoryScNotify other)
	{
		if (other != null)
		{
			if (other.IENBKIAGPBA != 0)
			{
				IENBKIAGPBA = other.IENBKIAGPBA;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IENBKIAGPBA = input.ReadUInt32();
			}
		}
	}
}

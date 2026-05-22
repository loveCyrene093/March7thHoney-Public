using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcMonsterExtraInfo : IMessage<NpcMonsterExtraInfo>, IMessage, IEquatable<NpcMonsterExtraInfo>, IDeepCloneable<NpcMonsterExtraInfo>, IBufferMessage
{
	private static readonly MessageParser<NpcMonsterExtraInfo> _parser = new MessageParser<NpcMonsterExtraInfo>(() => new NpcMonsterExtraInfo());

	private UnknownFieldSet _unknownFields;

	public const int RogueGameInfoFieldNumber = 7;

	private NpcMonsterRogueInfo rogueGameInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NpcMonsterExtraInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NpcMonsterExtraInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcMonsterRogueInfo RogueGameInfo
	{
		get
		{
			return rogueGameInfo_;
		}
		set
		{
			rogueGameInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcMonsterExtraInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcMonsterExtraInfo(NpcMonsterExtraInfo other)
		: this()
	{
		rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcMonsterExtraInfo Clone()
	{
		return new NpcMonsterExtraInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NpcMonsterExtraInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NpcMonsterExtraInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RogueGameInfo, other.RogueGameInfo))
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
		if (rogueGameInfo_ != null)
		{
			num ^= RogueGameInfo.GetHashCode();
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
		if (rogueGameInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(RogueGameInfo);
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
		if (rogueGameInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGameInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NpcMonsterExtraInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rogueGameInfo_ != null)
		{
			if (rogueGameInfo_ == null)
			{
				RogueGameInfo = new NpcMonsterRogueInfo();
			}
			RogueGameInfo.MergeFrom(other.RogueGameInfo);
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
			if (num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (rogueGameInfo_ == null)
			{
				RogueGameInfo = new NpcMonsterRogueInfo();
			}
			input.ReadMessage(RogueGameInfo);
		}
	}
}

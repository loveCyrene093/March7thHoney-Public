using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicStoryInfoUpdateScNotify : IMessage<RogueMagicStoryInfoUpdateScNotify>, IMessage, IEquatable<RogueMagicStoryInfoUpdateScNotify>, IDeepCloneable<RogueMagicStoryInfoUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicStoryInfoUpdateScNotify> _parser = new MessageParser<RogueMagicStoryInfoUpdateScNotify>(() => new RogueMagicStoryInfoUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KHMPDBNFKHBFieldNumber = 13;

	private uint kHMPDBNFKHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicStoryInfoUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicStoryInfoUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHMPDBNFKHB
	{
		get
		{
			return kHMPDBNFKHB_;
		}
		set
		{
			kHMPDBNFKHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicStoryInfoUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicStoryInfoUpdateScNotify(RogueMagicStoryInfoUpdateScNotify other)
		: this()
	{
		kHMPDBNFKHB_ = other.kHMPDBNFKHB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicStoryInfoUpdateScNotify Clone()
	{
		return new RogueMagicStoryInfoUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicStoryInfoUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicStoryInfoUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KHMPDBNFKHB != other.KHMPDBNFKHB)
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
		if (KHMPDBNFKHB != 0)
		{
			num ^= KHMPDBNFKHB.GetHashCode();
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
		if (KHMPDBNFKHB != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(KHMPDBNFKHB);
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
		if (KHMPDBNFKHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHMPDBNFKHB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicStoryInfoUpdateScNotify other)
	{
		if (other != null)
		{
			if (other.KHMPDBNFKHB != 0)
			{
				KHMPDBNFKHB = other.KHMPDBNFKHB;
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
			if (num != 104)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KHMPDBNFKHB = input.ReadUInt32();
			}
		}
	}
}

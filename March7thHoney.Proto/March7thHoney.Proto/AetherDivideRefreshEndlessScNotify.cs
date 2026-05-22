using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AetherDivideRefreshEndlessScNotify : IMessage<AetherDivideRefreshEndlessScNotify>, IMessage, IEquatable<AetherDivideRefreshEndlessScNotify>, IDeepCloneable<AetherDivideRefreshEndlessScNotify>, IBufferMessage
{
	private static readonly MessageParser<AetherDivideRefreshEndlessScNotify> _parser = new MessageParser<AetherDivideRefreshEndlessScNotify>(() => new AetherDivideRefreshEndlessScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KBFFBPDDCFFFieldNumber = 5;

	private uint kBFFBPDDCFF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AetherDivideRefreshEndlessScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AetherDivideRefreshEndlessScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBFFBPDDCFF
	{
		get
		{
			return kBFFBPDDCFF_;
		}
		set
		{
			kBFFBPDDCFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideRefreshEndlessScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideRefreshEndlessScNotify(AetherDivideRefreshEndlessScNotify other)
		: this()
	{
		kBFFBPDDCFF_ = other.kBFFBPDDCFF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideRefreshEndlessScNotify Clone()
	{
		return new AetherDivideRefreshEndlessScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AetherDivideRefreshEndlessScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AetherDivideRefreshEndlessScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KBFFBPDDCFF != other.KBFFBPDDCFF)
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
		if (KBFFBPDDCFF != 0)
		{
			num ^= KBFFBPDDCFF.GetHashCode();
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
		if (KBFFBPDDCFF != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(KBFFBPDDCFF);
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
		if (KBFFBPDDCFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBFFBPDDCFF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AetherDivideRefreshEndlessScNotify other)
	{
		if (other != null)
		{
			if (other.KBFFBPDDCFF != 0)
			{
				KBFFBPDDCFF = other.KBFFBPDDCFF;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KBFFBPDDCFF = input.ReadUInt32();
			}
		}
	}
}

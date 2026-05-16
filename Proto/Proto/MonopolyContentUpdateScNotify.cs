using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyContentUpdateScNotify : IMessage<MonopolyContentUpdateScNotify>, IMessage, IEquatable<MonopolyContentUpdateScNotify>, IDeepCloneable<MonopolyContentUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyContentUpdateScNotify> _parser = new MessageParser<MonopolyContentUpdateScNotify>(() => new MonopolyContentUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int NDIOFKHOBKMFieldNumber = 12;

	private BLIJEKKOIJH nDIOFKHOBKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyContentUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyContentUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLIJEKKOIJH NDIOFKHOBKM
	{
		get
		{
			return nDIOFKHOBKM_;
		}
		set
		{
			nDIOFKHOBKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyContentUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyContentUpdateScNotify(MonopolyContentUpdateScNotify other)
		: this()
	{
		nDIOFKHOBKM_ = ((other.nDIOFKHOBKM_ != null) ? other.nDIOFKHOBKM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyContentUpdateScNotify Clone()
	{
		return new MonopolyContentUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyContentUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyContentUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NDIOFKHOBKM, other.NDIOFKHOBKM))
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
		if (nDIOFKHOBKM_ != null)
		{
			num ^= NDIOFKHOBKM.GetHashCode();
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
		if (nDIOFKHOBKM_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(NDIOFKHOBKM);
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
		if (nDIOFKHOBKM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NDIOFKHOBKM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyContentUpdateScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nDIOFKHOBKM_ != null)
		{
			if (nDIOFKHOBKM_ == null)
			{
				NDIOFKHOBKM = new BLIJEKKOIJH();
			}
			NDIOFKHOBKM.MergeFrom(other.NDIOFKHOBKM);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (nDIOFKHOBKM_ == null)
			{
				NDIOFKHOBKM = new BLIJEKKOIJH();
			}
			input.ReadMessage(NDIOFKHOBKM);
		}
	}
}

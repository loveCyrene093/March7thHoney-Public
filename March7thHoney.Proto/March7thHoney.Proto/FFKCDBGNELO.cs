using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FFKCDBGNELO : IMessage<FFKCDBGNELO>, IMessage, IEquatable<FFKCDBGNELO>, IDeepCloneable<FFKCDBGNELO>, IBufferMessage
{
	private static readonly MessageParser<FFKCDBGNELO> _parser = new MessageParser<FFKCDBGNELO>(() => new FFKCDBGNELO());

	private UnknownFieldSet _unknownFields;

	public const int NDIOFKHOBKMFieldNumber = 13;

	private BLIJEKKOIJH nDIOFKHOBKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FFKCDBGNELO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FFKCDBGNELOReflection.Descriptor.MessageTypes[0];

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
	public FFKCDBGNELO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFKCDBGNELO(FFKCDBGNELO other)
		: this()
	{
		nDIOFKHOBKM_ = ((other.nDIOFKHOBKM_ != null) ? other.nDIOFKHOBKM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFKCDBGNELO Clone()
	{
		return new FFKCDBGNELO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FFKCDBGNELO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FFKCDBGNELO other)
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
			output.WriteRawTag(106);
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
	public void MergeFrom(FFKCDBGNELO other)
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
			if (num != 106)
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

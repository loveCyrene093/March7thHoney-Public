using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DEFOJHBBIDK : IMessage<DEFOJHBBIDK>, IMessage, IEquatable<DEFOJHBBIDK>, IDeepCloneable<DEFOJHBBIDK>, IBufferMessage
{
	private static readonly MessageParser<DEFOJHBBIDK> _parser = new MessageParser<DEFOJHBBIDK>(() => new DEFOJHBBIDK());

	private UnknownFieldSet _unknownFields;

	public const int PNKGNIIDJAAFieldNumber = 8;

	private uint pNKGNIIDJAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DEFOJHBBIDK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DEFOJHBBIDKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNKGNIIDJAA
	{
		get
		{
			return pNKGNIIDJAA_;
		}
		set
		{
			pNKGNIIDJAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEFOJHBBIDK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEFOJHBBIDK(DEFOJHBBIDK other)
		: this()
	{
		pNKGNIIDJAA_ = other.pNKGNIIDJAA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEFOJHBBIDK Clone()
	{
		return new DEFOJHBBIDK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DEFOJHBBIDK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DEFOJHBBIDK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PNKGNIIDJAA != other.PNKGNIIDJAA)
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
		if (PNKGNIIDJAA != 0)
		{
			num ^= PNKGNIIDJAA.GetHashCode();
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
		if (PNKGNIIDJAA != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PNKGNIIDJAA);
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
		if (PNKGNIIDJAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNKGNIIDJAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DEFOJHBBIDK other)
	{
		if (other != null)
		{
			if (other.PNKGNIIDJAA != 0)
			{
				PNKGNIIDJAA = other.PNKGNIIDJAA;
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
			if (num != 64)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				PNKGNIIDJAA = input.ReadUInt32();
			}
		}
	}
}

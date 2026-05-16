using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FDOEMKPGHFL : IMessage<FDOEMKPGHFL>, IMessage, IEquatable<FDOEMKPGHFL>, IDeepCloneable<FDOEMKPGHFL>, IBufferMessage
{
	private static readonly MessageParser<FDOEMKPGHFL> _parser = new MessageParser<FDOEMKPGHFL>(() => new FDOEMKPGHFL());

	private UnknownFieldSet _unknownFields;

	public const int XFieldNumber = 7;

	private int x_;

	public const int YFieldNumber = 13;

	private int y_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FDOEMKPGHFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FDOEMKPGHFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int X
	{
		get
		{
			return x_;
		}
		set
		{
			x_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Y
	{
		get
		{
			return y_;
		}
		set
		{
			y_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDOEMKPGHFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDOEMKPGHFL(FDOEMKPGHFL other)
		: this()
	{
		x_ = other.x_;
		y_ = other.y_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDOEMKPGHFL Clone()
	{
		return new FDOEMKPGHFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FDOEMKPGHFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FDOEMKPGHFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (X != other.X)
		{
			return false;
		}
		if (Y != other.Y)
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
		if (X != 0)
		{
			num ^= X.GetHashCode();
		}
		if (Y != 0)
		{
			num ^= Y.GetHashCode();
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
		if (X != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(X);
		}
		if (Y != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(Y);
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
		if (X != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(X);
		}
		if (Y != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Y);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FDOEMKPGHFL other)
	{
		if (other != null)
		{
			if (other.X != 0)
			{
				X = other.X;
			}
			if (other.Y != 0)
			{
				Y = other.Y;
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
			case 56u:
				X = input.ReadInt32();
				break;
			case 104u:
				Y = input.ReadInt32();
				break;
			}
		}
	}
}

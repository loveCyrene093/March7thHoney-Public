using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Vector : IMessage<Vector>, IMessage, IEquatable<Vector>, IDeepCloneable<Vector>, IBufferMessage
{
	private static readonly MessageParser<Vector> _parser = new MessageParser<Vector>(() => new Vector());

	private UnknownFieldSet _unknownFields;

	public const int XFieldNumber = 1;

	private int x_;

	public const int YFieldNumber = 2;

	private int y_;

	public const int ZFieldNumber = 3;

	private int z_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Vector> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => VectorReflection.Descriptor.MessageTypes[0];

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
	public int Z
	{
		get
		{
			return z_;
		}
		set
		{
			z_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector(Vector other)
		: this()
	{
		x_ = other.x_;
		y_ = other.y_;
		z_ = other.z_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector Clone()
	{
		return new Vector(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Vector);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Vector other)
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
		if (Z != other.Z)
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
		if (Z != 0)
		{
			num ^= Z.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteSInt32(X);
		}
		if (Y != 0)
		{
			output.WriteRawTag(16);
			output.WriteSInt32(Y);
		}
		if (Z != 0)
		{
			output.WriteRawTag(24);
			output.WriteSInt32(Z);
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
			num += 1 + CodedOutputStream.ComputeSInt32Size(X);
		}
		if (Y != 0)
		{
			num += 1 + CodedOutputStream.ComputeSInt32Size(Y);
		}
		if (Z != 0)
		{
			num += 1 + CodedOutputStream.ComputeSInt32Size(Z);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Vector other)
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
			if (other.Z != 0)
			{
				Z = other.Z;
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
				X = input.ReadSInt32();
				break;
			case 16u:
				Y = input.ReadSInt32();
				break;
			case 24u:
				Z = input.ReadSInt32();
				break;
			}
		}
	}
}

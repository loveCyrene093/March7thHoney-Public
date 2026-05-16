using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Vector4 : IMessage<Vector4>, IMessage, IEquatable<Vector4>, IDeepCloneable<Vector4>, IBufferMessage
{
	private static readonly MessageParser<Vector4> _parser = new MessageParser<Vector4>(() => new Vector4());

	private UnknownFieldSet _unknownFields;

	public const int XFieldNumber = 2;

	private float x_;

	public const int YFieldNumber = 7;

	private float y_;

	public const int WFieldNumber = 12;

	private float w_;

	public const int ZFieldNumber = 13;

	private float z_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Vector4> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => Vector4Reflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float X
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
	public float Y
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
	public float W
	{
		get
		{
			return w_;
		}
		set
		{
			w_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float Z
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
	public Vector4()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector4(Vector4 other)
		: this()
	{
		x_ = other.x_;
		y_ = other.y_;
		w_ = other.w_;
		z_ = other.z_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector4 Clone()
	{
		return new Vector4(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Vector4);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Vector4 other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(W, other.W))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z))
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
		if (X != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
		}
		if (Y != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
		}
		if (W != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(W);
		}
		if (Z != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
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
		if (X != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(X);
		}
		if (Y != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(Y);
		}
		if (W != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(W);
		}
		if (Z != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(Z);
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
		if (X != 0f)
		{
			num += 5;
		}
		if (Y != 0f)
		{
			num += 5;
		}
		if (W != 0f)
		{
			num += 5;
		}
		if (Z != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Vector4 other)
	{
		if (other != null)
		{
			if (other.X != 0f)
			{
				X = other.X;
			}
			if (other.Y != 0f)
			{
				Y = other.Y;
			}
			if (other.W != 0f)
			{
				W = other.W;
			}
			if (other.Z != 0f)
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
			case 21u:
				X = input.ReadFloat();
				break;
			case 61u:
				Y = input.ReadFloat();
				break;
			case 101u:
				W = input.ReadFloat();
				break;
			case 109u:
				Z = input.ReadFloat();
				break;
			}
		}
	}
}

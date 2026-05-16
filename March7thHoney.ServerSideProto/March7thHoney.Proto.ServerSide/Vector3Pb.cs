using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Vector3Pb : IMessage<Vector3Pb>, IMessage, IEquatable<Vector3Pb>, IDeepCloneable<Vector3Pb>, IBufferMessage
{
	private static readonly MessageParser<Vector3Pb> _parser = new MessageParser<Vector3Pb>(() => new Vector3Pb());

	private UnknownFieldSet _unknownFields;

	public const int XFieldNumber = 1;

	private int x_;

	public const int YFieldNumber = 2;

	private int y_;

	public const int ZFieldNumber = 3;

	private int z_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Vector3Pb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeDataReflection.Descriptor.MessageTypes[0];

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
	public Vector3Pb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector3Pb(Vector3Pb other)
		: this()
	{
		x_ = other.x_;
		y_ = other.y_;
		z_ = other.z_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector3Pb Clone()
	{
		return new Vector3Pb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Vector3Pb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Vector3Pb other)
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
			output.WriteInt32(X);
		}
		if (Y != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Y);
		}
		if (Z != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Z);
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
		if (Z != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Z);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Vector3Pb other)
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				X = input.ReadInt32();
				break;
			case 16u:
				Y = input.ReadInt32();
				break;
			case 24u:
				Z = input.ReadInt32();
				break;
			}
		}
	}
}

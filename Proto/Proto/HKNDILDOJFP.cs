using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HKNDILDOJFP : IMessage<HKNDILDOJFP>, IMessage, IEquatable<HKNDILDOJFP>, IDeepCloneable<HKNDILDOJFP>, IBufferMessage
{
	private static readonly MessageParser<HKNDILDOJFP> _parser = new MessageParser<HKNDILDOJFP>(() => new HKNDILDOJFP());

	private UnknownFieldSet _unknownFields;

	public const int IGMMPDDCJINFieldNumber = 1;

	private uint iGMMPDDCJIN_;

	public const int JHFKANKGLJNFieldNumber = 2;

	private double jHFKANKGLJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HKNDILDOJFP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HKNDILDOJFPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGMMPDDCJIN
	{
		get
		{
			return iGMMPDDCJIN_;
		}
		set
		{
			iGMMPDDCJIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double JHFKANKGLJN
	{
		get
		{
			return jHFKANKGLJN_;
		}
		set
		{
			jHFKANKGLJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKNDILDOJFP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKNDILDOJFP(HKNDILDOJFP other)
		: this()
	{
		iGMMPDDCJIN_ = other.iGMMPDDCJIN_;
		jHFKANKGLJN_ = other.jHFKANKGLJN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKNDILDOJFP Clone()
	{
		return new HKNDILDOJFP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HKNDILDOJFP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HKNDILDOJFP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IGMMPDDCJIN != other.IGMMPDDCJIN)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(JHFKANKGLJN, other.JHFKANKGLJN))
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
		if (IGMMPDDCJIN != 0)
		{
			num ^= IGMMPDDCJIN.GetHashCode();
		}
		if (JHFKANKGLJN != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(JHFKANKGLJN);
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
		if (IGMMPDDCJIN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IGMMPDDCJIN);
		}
		if (JHFKANKGLJN != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(JHFKANKGLJN);
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
		if (IGMMPDDCJIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGMMPDDCJIN);
		}
		if (JHFKANKGLJN != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HKNDILDOJFP other)
	{
		if (other != null)
		{
			if (other.IGMMPDDCJIN != 0)
			{
				IGMMPDDCJIN = other.IGMMPDDCJIN;
			}
			if (other.JHFKANKGLJN != 0.0)
			{
				JHFKANKGLJN = other.JHFKANKGLJN;
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
				IGMMPDDCJIN = input.ReadUInt32();
				break;
			case 17u:
				JHFKANKGLJN = input.ReadDouble();
				break;
			}
		}
	}
}

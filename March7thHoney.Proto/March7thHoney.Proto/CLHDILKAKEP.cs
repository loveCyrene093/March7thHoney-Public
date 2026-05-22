using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CLHDILKAKEP : IMessage<CLHDILKAKEP>, IMessage, IEquatable<CLHDILKAKEP>, IDeepCloneable<CLHDILKAKEP>, IBufferMessage
{
	private static readonly MessageParser<CLHDILKAKEP> _parser = new MessageParser<CLHDILKAKEP>(() => new CLHDILKAKEP());

	private UnknownFieldSet _unknownFields;

	public const int FBCJCKEAHCMFieldNumber = 8;

	private uint fBCJCKEAHCM_;

	public const int OGKNEBGDEFNFieldNumber = 12;

	private uint oGKNEBGDEFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CLHDILKAKEP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CLHDILKAKEPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FBCJCKEAHCM
	{
		get
		{
			return fBCJCKEAHCM_;
		}
		set
		{
			fBCJCKEAHCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OGKNEBGDEFN
	{
		get
		{
			return oGKNEBGDEFN_;
		}
		set
		{
			oGKNEBGDEFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLHDILKAKEP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLHDILKAKEP(CLHDILKAKEP other)
		: this()
	{
		fBCJCKEAHCM_ = other.fBCJCKEAHCM_;
		oGKNEBGDEFN_ = other.oGKNEBGDEFN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLHDILKAKEP Clone()
	{
		return new CLHDILKAKEP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CLHDILKAKEP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CLHDILKAKEP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FBCJCKEAHCM != other.FBCJCKEAHCM)
		{
			return false;
		}
		if (OGKNEBGDEFN != other.OGKNEBGDEFN)
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
		if (FBCJCKEAHCM != 0)
		{
			num ^= FBCJCKEAHCM.GetHashCode();
		}
		if (OGKNEBGDEFN != 0)
		{
			num ^= OGKNEBGDEFN.GetHashCode();
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
		if (FBCJCKEAHCM != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FBCJCKEAHCM);
		}
		if (OGKNEBGDEFN != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OGKNEBGDEFN);
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
		if (FBCJCKEAHCM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBCJCKEAHCM);
		}
		if (OGKNEBGDEFN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGKNEBGDEFN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CLHDILKAKEP other)
	{
		if (other != null)
		{
			if (other.FBCJCKEAHCM != 0)
			{
				FBCJCKEAHCM = other.FBCJCKEAHCM;
			}
			if (other.OGKNEBGDEFN != 0)
			{
				OGKNEBGDEFN = other.OGKNEBGDEFN;
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
			case 64u:
				FBCJCKEAHCM = input.ReadUInt32();
				break;
			case 96u:
				OGKNEBGDEFN = input.ReadUInt32();
				break;
			}
		}
	}
}

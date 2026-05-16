using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OBCJLDDEBHL : IMessage<OBCJLDDEBHL>, IMessage, IEquatable<OBCJLDDEBHL>, IDeepCloneable<OBCJLDDEBHL>, IBufferMessage
{
	private static readonly MessageParser<OBCJLDDEBHL> _parser = new MessageParser<OBCJLDDEBHL>(() => new OBCJLDDEBHL());

	private UnknownFieldSet _unknownFields;

	public const int PNIDNOGHMBHFieldNumber = 1;

	private uint pNIDNOGHMBH_;

	public const int CMAPCGGABJIFieldNumber = 8;

	private uint cMAPCGGABJI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OBCJLDDEBHL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OBCJLDDEBHLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNIDNOGHMBH
	{
		get
		{
			return pNIDNOGHMBH_;
		}
		set
		{
			pNIDNOGHMBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CMAPCGGABJI
	{
		get
		{
			return cMAPCGGABJI_;
		}
		set
		{
			cMAPCGGABJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBCJLDDEBHL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBCJLDDEBHL(OBCJLDDEBHL other)
		: this()
	{
		pNIDNOGHMBH_ = other.pNIDNOGHMBH_;
		cMAPCGGABJI_ = other.cMAPCGGABJI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBCJLDDEBHL Clone()
	{
		return new OBCJLDDEBHL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OBCJLDDEBHL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OBCJLDDEBHL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PNIDNOGHMBH != other.PNIDNOGHMBH)
		{
			return false;
		}
		if (CMAPCGGABJI != other.CMAPCGGABJI)
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
		if (PNIDNOGHMBH != 0)
		{
			num ^= PNIDNOGHMBH.GetHashCode();
		}
		if (CMAPCGGABJI != 0)
		{
			num ^= CMAPCGGABJI.GetHashCode();
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
		if (PNIDNOGHMBH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PNIDNOGHMBH);
		}
		if (CMAPCGGABJI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CMAPCGGABJI);
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
		if (PNIDNOGHMBH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNIDNOGHMBH);
		}
		if (CMAPCGGABJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CMAPCGGABJI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OBCJLDDEBHL other)
	{
		if (other != null)
		{
			if (other.PNIDNOGHMBH != 0)
			{
				PNIDNOGHMBH = other.PNIDNOGHMBH;
			}
			if (other.CMAPCGGABJI != 0)
			{
				CMAPCGGABJI = other.CMAPCGGABJI;
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
				PNIDNOGHMBH = input.ReadUInt32();
				break;
			case 64u:
				CMAPCGGABJI = input.ReadUInt32();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GOOBKLOEKFO : IMessage<GOOBKLOEKFO>, IMessage, IEquatable<GOOBKLOEKFO>, IDeepCloneable<GOOBKLOEKFO>, IBufferMessage
{
	private static readonly MessageParser<GOOBKLOEKFO> _parser = new MessageParser<GOOBKLOEKFO>(() => new GOOBKLOEKFO());

	private UnknownFieldSet _unknownFields;

	public const int EMFHLBBOCFKFieldNumber = 1;

	private uint eMFHLBBOCFK_;

	public const int LJDIGNDGCFJFieldNumber = 5;

	private uint lJDIGNDGCFJ_;

	public const int JKCGCAMIFIAFieldNumber = 10;

	private uint jKCGCAMIFIA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GOOBKLOEKFO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GOOBKLOEKFOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EMFHLBBOCFK
	{
		get
		{
			return eMFHLBBOCFK_;
		}
		set
		{
			eMFHLBBOCFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LJDIGNDGCFJ
	{
		get
		{
			return lJDIGNDGCFJ_;
		}
		set
		{
			lJDIGNDGCFJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKCGCAMIFIA
	{
		get
		{
			return jKCGCAMIFIA_;
		}
		set
		{
			jKCGCAMIFIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOOBKLOEKFO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOOBKLOEKFO(GOOBKLOEKFO other)
		: this()
	{
		eMFHLBBOCFK_ = other.eMFHLBBOCFK_;
		lJDIGNDGCFJ_ = other.lJDIGNDGCFJ_;
		jKCGCAMIFIA_ = other.jKCGCAMIFIA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOOBKLOEKFO Clone()
	{
		return new GOOBKLOEKFO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GOOBKLOEKFO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GOOBKLOEKFO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EMFHLBBOCFK != other.EMFHLBBOCFK)
		{
			return false;
		}
		if (LJDIGNDGCFJ != other.LJDIGNDGCFJ)
		{
			return false;
		}
		if (JKCGCAMIFIA != other.JKCGCAMIFIA)
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
		if (EMFHLBBOCFK != 0)
		{
			num ^= EMFHLBBOCFK.GetHashCode();
		}
		if (LJDIGNDGCFJ != 0)
		{
			num ^= LJDIGNDGCFJ.GetHashCode();
		}
		if (JKCGCAMIFIA != 0)
		{
			num ^= JKCGCAMIFIA.GetHashCode();
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
		if (EMFHLBBOCFK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EMFHLBBOCFK);
		}
		if (LJDIGNDGCFJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LJDIGNDGCFJ);
		}
		if (JKCGCAMIFIA != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(JKCGCAMIFIA);
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
		if (EMFHLBBOCFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EMFHLBBOCFK);
		}
		if (LJDIGNDGCFJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LJDIGNDGCFJ);
		}
		if (JKCGCAMIFIA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKCGCAMIFIA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GOOBKLOEKFO other)
	{
		if (other != null)
		{
			if (other.EMFHLBBOCFK != 0)
			{
				EMFHLBBOCFK = other.EMFHLBBOCFK;
			}
			if (other.LJDIGNDGCFJ != 0)
			{
				LJDIGNDGCFJ = other.LJDIGNDGCFJ;
			}
			if (other.JKCGCAMIFIA != 0)
			{
				JKCGCAMIFIA = other.JKCGCAMIFIA;
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
				EMFHLBBOCFK = input.ReadUInt32();
				break;
			case 40u:
				LJDIGNDGCFJ = input.ReadUInt32();
				break;
			case 80u:
				JKCGCAMIFIA = input.ReadUInt32();
				break;
			}
		}
	}
}

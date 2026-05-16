using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ALHGCBPJLMO : IMessage<ALHGCBPJLMO>, IMessage, IEquatable<ALHGCBPJLMO>, IDeepCloneable<ALHGCBPJLMO>, IBufferMessage
{
	public enum IIGFMDHKBADOneofCase
	{
		None = 0,
		UniqueId = 4,
		KGGOBNFHEPF = 6
	}

	private static readonly MessageParser<ALHGCBPJLMO> _parser = new MessageParser<ALHGCBPJLMO>(() => new ALHGCBPJLMO());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 4;

	public const int KGGOBNFHEPFFieldNumber = 6;

	private object iIGFMDHKBAD_;

	private IIGFMDHKBADOneofCase iIGFMDHKBADCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ALHGCBPJLMO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ALHGCBPJLMOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			if (!HasUniqueId)
			{
				return 0u;
			}
			return (uint)iIGFMDHKBAD_;
		}
		set
		{
			iIGFMDHKBAD_ = value;
			iIGFMDHKBADCase_ = IIGFMDHKBADOneofCase.UniqueId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasUniqueId => iIGFMDHKBADCase_ == IIGFMDHKBADOneofCase.UniqueId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KGGOBNFHEPF
	{
		get
		{
			if (!HasKGGOBNFHEPF)
			{
				return 0u;
			}
			return (uint)iIGFMDHKBAD_;
		}
		set
		{
			iIGFMDHKBAD_ = value;
			iIGFMDHKBADCase_ = IIGFMDHKBADOneofCase.KGGOBNFHEPF;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasKGGOBNFHEPF => iIGFMDHKBADCase_ == IIGFMDHKBADOneofCase.KGGOBNFHEPF;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIGFMDHKBADOneofCase IIGFMDHKBADCase => iIGFMDHKBADCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALHGCBPJLMO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALHGCBPJLMO(ALHGCBPJLMO other)
		: this()
	{
		switch (other.IIGFMDHKBADCase)
		{
		case IIGFMDHKBADOneofCase.UniqueId:
			UniqueId = other.UniqueId;
			break;
		case IIGFMDHKBADOneofCase.KGGOBNFHEPF:
			KGGOBNFHEPF = other.KGGOBNFHEPF;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALHGCBPJLMO Clone()
	{
		return new ALHGCBPJLMO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearUniqueId()
	{
		if (HasUniqueId)
		{
			ClearIIGFMDHKBAD();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKGGOBNFHEPF()
	{
		if (HasKGGOBNFHEPF)
		{
			ClearIIGFMDHKBAD();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearIIGFMDHKBAD()
	{
		iIGFMDHKBADCase_ = IIGFMDHKBADOneofCase.None;
		iIGFMDHKBAD_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ALHGCBPJLMO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ALHGCBPJLMO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (KGGOBNFHEPF != other.KGGOBNFHEPF)
		{
			return false;
		}
		if (IIGFMDHKBADCase != other.IIGFMDHKBADCase)
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
		if (HasUniqueId)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (HasKGGOBNFHEPF)
		{
			num ^= KGGOBNFHEPF.GetHashCode();
		}
		num ^= (int)iIGFMDHKBADCase_;
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
		if (HasUniqueId)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(UniqueId);
		}
		if (HasKGGOBNFHEPF)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KGGOBNFHEPF);
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
		if (HasUniqueId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (HasKGGOBNFHEPF)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KGGOBNFHEPF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ALHGCBPJLMO other)
	{
		if (other != null)
		{
			switch (other.IIGFMDHKBADCase)
			{
			case IIGFMDHKBADOneofCase.UniqueId:
				UniqueId = other.UniqueId;
				break;
			case IIGFMDHKBADOneofCase.KGGOBNFHEPF:
				KGGOBNFHEPF = other.KGGOBNFHEPF;
				break;
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
			case 32u:
				UniqueId = input.ReadUInt32();
				break;
			case 48u:
				KGGOBNFHEPF = input.ReadUInt32();
				break;
			}
		}
	}
}

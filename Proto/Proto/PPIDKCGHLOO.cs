using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PPIDKCGHLOO : IMessage<PPIDKCGHLOO>, IMessage, IEquatable<PPIDKCGHLOO>, IDeepCloneable<PPIDKCGHLOO>, IBufferMessage
{
	private static readonly MessageParser<PPIDKCGHLOO> _parser = new MessageParser<PPIDKCGHLOO>(() => new PPIDKCGHLOO());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int IEPPFKGBFEPFieldNumber = 7;

	private uint iEPPFKGBFEP_;

	public const int OLONCNOLNHNFieldNumber = 8;

	private uint oLONCNOLNHN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PPIDKCGHLOO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PPIDKCGHLOOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IEPPFKGBFEP
	{
		get
		{
			return iEPPFKGBFEP_;
		}
		set
		{
			iEPPFKGBFEP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OLONCNOLNHN
	{
		get
		{
			return oLONCNOLNHN_;
		}
		set
		{
			oLONCNOLNHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPIDKCGHLOO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPIDKCGHLOO(PPIDKCGHLOO other)
		: this()
	{
		retcode_ = other.retcode_;
		iEPPFKGBFEP_ = other.iEPPFKGBFEP_;
		oLONCNOLNHN_ = other.oLONCNOLNHN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPIDKCGHLOO Clone()
	{
		return new PPIDKCGHLOO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PPIDKCGHLOO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PPIDKCGHLOO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (IEPPFKGBFEP != other.IEPPFKGBFEP)
		{
			return false;
		}
		if (OLONCNOLNHN != other.OLONCNOLNHN)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (IEPPFKGBFEP != 0)
		{
			num ^= IEPPFKGBFEP.GetHashCode();
		}
		if (OLONCNOLNHN != 0)
		{
			num ^= OLONCNOLNHN.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (IEPPFKGBFEP != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IEPPFKGBFEP);
		}
		if (OLONCNOLNHN != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(OLONCNOLNHN);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (IEPPFKGBFEP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IEPPFKGBFEP);
		}
		if (OLONCNOLNHN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OLONCNOLNHN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PPIDKCGHLOO other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.IEPPFKGBFEP != 0)
			{
				IEPPFKGBFEP = other.IEPPFKGBFEP;
			}
			if (other.OLONCNOLNHN != 0)
			{
				OLONCNOLNHN = other.OLONCNOLNHN;
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 56u:
				IEPPFKGBFEP = input.ReadUInt32();
				break;
			case 64u:
				OLONCNOLNHN = input.ReadUInt32();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EDKFJKKCIID : IMessage<EDKFJKKCIID>, IMessage, IEquatable<EDKFJKKCIID>, IDeepCloneable<EDKFJKKCIID>, IBufferMessage
{
	private static readonly MessageParser<EDKFJKKCIID> _parser = new MessageParser<EDKFJKKCIID>(() => new EDKFJKKCIID());

	private UnknownFieldSet _unknownFields;

	public const int PHDLMLHKIHHFieldNumber = 5;

	private uint pHDLMLHKIHH_;

	public const int POCEEJLGAMHFieldNumber = 10;

	private uint pOCEEJLGAMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EDKFJKKCIID> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EDKFJKKCIIDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHDLMLHKIHH
	{
		get
		{
			return pHDLMLHKIHH_;
		}
		set
		{
			pHDLMLHKIHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint POCEEJLGAMH
	{
		get
		{
			return pOCEEJLGAMH_;
		}
		set
		{
			pOCEEJLGAMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDKFJKKCIID()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDKFJKKCIID(EDKFJKKCIID other)
		: this()
	{
		pHDLMLHKIHH_ = other.pHDLMLHKIHH_;
		pOCEEJLGAMH_ = other.pOCEEJLGAMH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDKFJKKCIID Clone()
	{
		return new EDKFJKKCIID(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EDKFJKKCIID);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EDKFJKKCIID other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PHDLMLHKIHH != other.PHDLMLHKIHH)
		{
			return false;
		}
		if (POCEEJLGAMH != other.POCEEJLGAMH)
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
		if (PHDLMLHKIHH != 0)
		{
			num ^= PHDLMLHKIHH.GetHashCode();
		}
		if (POCEEJLGAMH != 0)
		{
			num ^= POCEEJLGAMH.GetHashCode();
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
		if (PHDLMLHKIHH != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PHDLMLHKIHH);
		}
		if (POCEEJLGAMH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(POCEEJLGAMH);
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
		if (PHDLMLHKIHH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHDLMLHKIHH);
		}
		if (POCEEJLGAMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(POCEEJLGAMH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EDKFJKKCIID other)
	{
		if (other != null)
		{
			if (other.PHDLMLHKIHH != 0)
			{
				PHDLMLHKIHH = other.PHDLMLHKIHH;
			}
			if (other.POCEEJLGAMH != 0)
			{
				POCEEJLGAMH = other.POCEEJLGAMH;
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
			case 40u:
				PHDLMLHKIHH = input.ReadUInt32();
				break;
			case 80u:
				POCEEJLGAMH = input.ReadUInt32();
				break;
			}
		}
	}
}

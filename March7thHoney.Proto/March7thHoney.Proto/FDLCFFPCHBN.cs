using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FDLCFFPCHBN : IMessage<FDLCFFPCHBN>, IMessage, IEquatable<FDLCFFPCHBN>, IDeepCloneable<FDLCFFPCHBN>, IBufferMessage
{
	private static readonly MessageParser<FDLCFFPCHBN> _parser = new MessageParser<FDLCFFPCHBN>(() => new FDLCFFPCHBN());

	private UnknownFieldSet _unknownFields;

	public const int POCIFNLEFHNFieldNumber = 1;

	private uint pOCIFNLEFHN_;

	public const int COEBHKFJJGOFieldNumber = 6;

	private uint cOEBHKFJJGO_;

	public const int BuffIdFieldNumber = 14;

	private uint buffId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FDLCFFPCHBN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FDLCFFPCHBNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint POCIFNLEFHN
	{
		get
		{
			return pOCIFNLEFHN_;
		}
		set
		{
			pOCIFNLEFHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COEBHKFJJGO
	{
		get
		{
			return cOEBHKFJJGO_;
		}
		set
		{
			cOEBHKFJJGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDLCFFPCHBN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDLCFFPCHBN(FDLCFFPCHBN other)
		: this()
	{
		pOCIFNLEFHN_ = other.pOCIFNLEFHN_;
		cOEBHKFJJGO_ = other.cOEBHKFJJGO_;
		buffId_ = other.buffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDLCFFPCHBN Clone()
	{
		return new FDLCFFPCHBN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FDLCFFPCHBN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FDLCFFPCHBN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (POCIFNLEFHN != other.POCIFNLEFHN)
		{
			return false;
		}
		if (COEBHKFJJGO != other.COEBHKFJJGO)
		{
			return false;
		}
		if (BuffId != other.BuffId)
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
		if (POCIFNLEFHN != 0)
		{
			num ^= POCIFNLEFHN.GetHashCode();
		}
		if (COEBHKFJJGO != 0)
		{
			num ^= COEBHKFJJGO.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
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
		if (POCIFNLEFHN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(POCIFNLEFHN);
		}
		if (COEBHKFJJGO != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(COEBHKFJJGO);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BuffId);
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
		if (POCIFNLEFHN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(POCIFNLEFHN);
		}
		if (COEBHKFJJGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COEBHKFJJGO);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FDLCFFPCHBN other)
	{
		if (other != null)
		{
			if (other.POCIFNLEFHN != 0)
			{
				POCIFNLEFHN = other.POCIFNLEFHN;
			}
			if (other.COEBHKFJJGO != 0)
			{
				COEBHKFJJGO = other.COEBHKFJJGO;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
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
				POCIFNLEFHN = input.ReadUInt32();
				break;
			case 48u:
				COEBHKFJJGO = input.ReadUInt32();
				break;
			case 112u:
				BuffId = input.ReadUInt32();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFGCNNPOADI : IMessage<KFGCNNPOADI>, IMessage, IEquatable<KFGCNNPOADI>, IDeepCloneable<KFGCNNPOADI>, IBufferMessage
{
	private static readonly MessageParser<KFGCNNPOADI> _parser = new MessageParser<KFGCNNPOADI>(() => new KFGCNNPOADI());

	private UnknownFieldSet _unknownFields;

	public const int MAFMCIPAIKKFieldNumber = 4;

	private uint mAFMCIPAIKK_;

	public const int OLKMILNGPNNFieldNumber = 10;

	private bool oLKMILNGPNN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFGCNNPOADI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFGCNNPOADIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAFMCIPAIKK
	{
		get
		{
			return mAFMCIPAIKK_;
		}
		set
		{
			mAFMCIPAIKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OLKMILNGPNN
	{
		get
		{
			return oLKMILNGPNN_;
		}
		set
		{
			oLKMILNGPNN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGCNNPOADI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGCNNPOADI(KFGCNNPOADI other)
		: this()
	{
		mAFMCIPAIKK_ = other.mAFMCIPAIKK_;
		oLKMILNGPNN_ = other.oLKMILNGPNN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGCNNPOADI Clone()
	{
		return new KFGCNNPOADI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFGCNNPOADI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFGCNNPOADI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MAFMCIPAIKK != other.MAFMCIPAIKK)
		{
			return false;
		}
		if (OLKMILNGPNN != other.OLKMILNGPNN)
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
		if (MAFMCIPAIKK != 0)
		{
			num ^= MAFMCIPAIKK.GetHashCode();
		}
		if (OLKMILNGPNN)
		{
			num ^= OLKMILNGPNN.GetHashCode();
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
		if (MAFMCIPAIKK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MAFMCIPAIKK);
		}
		if (OLKMILNGPNN)
		{
			output.WriteRawTag(80);
			output.WriteBool(OLKMILNGPNN);
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
		if (MAFMCIPAIKK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAFMCIPAIKK);
		}
		if (OLKMILNGPNN)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KFGCNNPOADI other)
	{
		if (other != null)
		{
			if (other.MAFMCIPAIKK != 0)
			{
				MAFMCIPAIKK = other.MAFMCIPAIKK;
			}
			if (other.OLKMILNGPNN)
			{
				OLKMILNGPNN = other.OLKMILNGPNN;
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
				MAFMCIPAIKK = input.ReadUInt32();
				break;
			case 80u:
				OLKMILNGPNN = input.ReadBool();
				break;
			}
		}
	}
}

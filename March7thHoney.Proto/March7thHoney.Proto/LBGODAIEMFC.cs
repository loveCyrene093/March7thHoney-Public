using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LBGODAIEMFC : IMessage<LBGODAIEMFC>, IMessage, IEquatable<LBGODAIEMFC>, IDeepCloneable<LBGODAIEMFC>, IBufferMessage
{
	private static readonly MessageParser<LBGODAIEMFC> _parser = new MessageParser<LBGODAIEMFC>(() => new LBGODAIEMFC());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int NNNFCOAFFAOFieldNumber = 15;

	private JIICPJNINBB nNNFCOAFFAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LBGODAIEMFC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LBGODAIEMFCReflection.Descriptor.MessageTypes[0];

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
	public JIICPJNINBB NNNFCOAFFAO
	{
		get
		{
			return nNNFCOAFFAO_;
		}
		set
		{
			nNNFCOAFFAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBGODAIEMFC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBGODAIEMFC(LBGODAIEMFC other)
		: this()
	{
		retcode_ = other.retcode_;
		nNNFCOAFFAO_ = ((other.nNNFCOAFFAO_ != null) ? other.nNNFCOAFFAO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBGODAIEMFC Clone()
	{
		return new LBGODAIEMFC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LBGODAIEMFC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LBGODAIEMFC other)
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
		if (!object.Equals(NNNFCOAFFAO, other.NNNFCOAFFAO))
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
		if (nNNFCOAFFAO_ != null)
		{
			num ^= NNNFCOAFFAO.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (nNNFCOAFFAO_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(NNNFCOAFFAO);
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
		if (nNNFCOAFFAO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NNNFCOAFFAO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LBGODAIEMFC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.nNNFCOAFFAO_ != null)
		{
			if (nNNFCOAFFAO_ == null)
			{
				NNNFCOAFFAO = new JIICPJNINBB();
			}
			NNNFCOAFFAO.MergeFrom(other.NNNFCOAFFAO);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				if (nNNFCOAFFAO_ == null)
				{
					NNNFCOAFFAO = new JIICPJNINBB();
				}
				input.ReadMessage(NNNFCOAFFAO);
				break;
			}
		}
	}
}

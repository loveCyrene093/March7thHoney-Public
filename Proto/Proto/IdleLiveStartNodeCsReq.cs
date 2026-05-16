using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveStartNodeCsReq : IMessage<IdleLiveStartNodeCsReq>, IMessage, IEquatable<IdleLiveStartNodeCsReq>, IDeepCloneable<IdleLiveStartNodeCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveStartNodeCsReq> _parser = new MessageParser<IdleLiveStartNodeCsReq>(() => new IdleLiveStartNodeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BIMKHABLGMCFieldNumber = 2;

	private uint bIMKHABLGMC_;

	public const int HAAAPFLGNBMFieldNumber = 9;

	private uint hAAAPFLGNBM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveStartNodeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveStartNodeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BIMKHABLGMC
	{
		get
		{
			return bIMKHABLGMC_;
		}
		set
		{
			bIMKHABLGMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HAAAPFLGNBM
	{
		get
		{
			return hAAAPFLGNBM_;
		}
		set
		{
			hAAAPFLGNBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveStartNodeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveStartNodeCsReq(IdleLiveStartNodeCsReq other)
		: this()
	{
		bIMKHABLGMC_ = other.bIMKHABLGMC_;
		hAAAPFLGNBM_ = other.hAAAPFLGNBM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveStartNodeCsReq Clone()
	{
		return new IdleLiveStartNodeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveStartNodeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveStartNodeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BIMKHABLGMC != other.BIMKHABLGMC)
		{
			return false;
		}
		if (HAAAPFLGNBM != other.HAAAPFLGNBM)
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
		if (BIMKHABLGMC != 0)
		{
			num ^= BIMKHABLGMC.GetHashCode();
		}
		if (HAAAPFLGNBM != 0)
		{
			num ^= HAAAPFLGNBM.GetHashCode();
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
		if (BIMKHABLGMC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BIMKHABLGMC);
		}
		if (HAAAPFLGNBM != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HAAAPFLGNBM);
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
		if (BIMKHABLGMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BIMKHABLGMC);
		}
		if (HAAAPFLGNBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HAAAPFLGNBM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveStartNodeCsReq other)
	{
		if (other != null)
		{
			if (other.BIMKHABLGMC != 0)
			{
				BIMKHABLGMC = other.BIMKHABLGMC;
			}
			if (other.HAAAPFLGNBM != 0)
			{
				HAAAPFLGNBM = other.HAAAPFLGNBM;
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
			case 16u:
				BIMKHABLGMC = input.ReadUInt32();
				break;
			case 72u:
				HAAAPFLGNBM = input.ReadUInt32();
				break;
			}
		}
	}
}

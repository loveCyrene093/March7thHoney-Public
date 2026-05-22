using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KMOFOOGIDOP : IMessage<KMOFOOGIDOP>, IMessage, IEquatable<KMOFOOGIDOP>, IDeepCloneable<KMOFOOGIDOP>, IBufferMessage
{
	private static readonly MessageParser<KMOFOOGIDOP> _parser = new MessageParser<KMOFOOGIDOP>(() => new KMOFOOGIDOP());

	private UnknownFieldSet _unknownFields;

	public const int PIBLJLBCKJLFieldNumber = 8;

	private GridFightDropInfo pIBLJLBCKJL_;

	public const int BDBFDNJFAFFFieldNumber = 14;

	private uint bDBFDNJFAFF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KMOFOOGIDOP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KMOFOOGIDOPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDropInfo PIBLJLBCKJL
	{
		get
		{
			return pIBLJLBCKJL_;
		}
		set
		{
			pIBLJLBCKJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BDBFDNJFAFF
	{
		get
		{
			return bDBFDNJFAFF_;
		}
		set
		{
			bDBFDNJFAFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMOFOOGIDOP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMOFOOGIDOP(KMOFOOGIDOP other)
		: this()
	{
		pIBLJLBCKJL_ = ((other.pIBLJLBCKJL_ != null) ? other.pIBLJLBCKJL_.Clone() : null);
		bDBFDNJFAFF_ = other.bDBFDNJFAFF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMOFOOGIDOP Clone()
	{
		return new KMOFOOGIDOP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KMOFOOGIDOP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KMOFOOGIDOP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PIBLJLBCKJL, other.PIBLJLBCKJL))
		{
			return false;
		}
		if (BDBFDNJFAFF != other.BDBFDNJFAFF)
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
		if (pIBLJLBCKJL_ != null)
		{
			num ^= PIBLJLBCKJL.GetHashCode();
		}
		if (BDBFDNJFAFF != 0)
		{
			num ^= BDBFDNJFAFF.GetHashCode();
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
		if (pIBLJLBCKJL_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(PIBLJLBCKJL);
		}
		if (BDBFDNJFAFF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BDBFDNJFAFF);
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
		if (pIBLJLBCKJL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PIBLJLBCKJL);
		}
		if (BDBFDNJFAFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BDBFDNJFAFF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KMOFOOGIDOP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pIBLJLBCKJL_ != null)
		{
			if (pIBLJLBCKJL_ == null)
			{
				PIBLJLBCKJL = new GridFightDropInfo();
			}
			PIBLJLBCKJL.MergeFrom(other.PIBLJLBCKJL);
		}
		if (other.BDBFDNJFAFF != 0)
		{
			BDBFDNJFAFF = other.BDBFDNJFAFF;
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
			case 66u:
				if (pIBLJLBCKJL_ == null)
				{
					PIBLJLBCKJL = new GridFightDropInfo();
				}
				input.ReadMessage(PIBLJLBCKJL);
				break;
			case 112u:
				BDBFDNJFAFF = input.ReadUInt32();
				break;
			}
		}
	}
}

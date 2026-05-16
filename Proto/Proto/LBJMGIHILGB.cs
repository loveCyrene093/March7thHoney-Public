using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LBJMGIHILGB : IMessage<LBJMGIHILGB>, IMessage, IEquatable<LBJMGIHILGB>, IDeepCloneable<LBJMGIHILGB>, IBufferMessage
{
	private static readonly MessageParser<LBJMGIHILGB> _parser = new MessageParser<LBJMGIHILGB>(() => new LBJMGIHILGB());

	private UnknownFieldSet _unknownFields;

	public const int EFGELJJFLKLFieldNumber = 2;

	private EFEGKDHEMFN eFGELJJFLKL_;

	public const int ANHGNLHNOKEFieldNumber = 6;

	private long aNHGNLHNOKE_;

	public const int IGLCEDBCKFHFieldNumber = 8;

	private EFEGKDHEMFN iGLCEDBCKFH_;

	public const int BHDHIIBCDIJFieldNumber = 11;

	private uint bHDHIIBCDIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LBJMGIHILGB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LBJMGIHILGBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN EFGELJJFLKL
	{
		get
		{
			return eFGELJJFLKL_;
		}
		set
		{
			eFGELJJFLKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ANHGNLHNOKE
	{
		get
		{
			return aNHGNLHNOKE_;
		}
		set
		{
			aNHGNLHNOKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN IGLCEDBCKFH
	{
		get
		{
			return iGLCEDBCKFH_;
		}
		set
		{
			iGLCEDBCKFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHDHIIBCDIJ
	{
		get
		{
			return bHDHIIBCDIJ_;
		}
		set
		{
			bHDHIIBCDIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBJMGIHILGB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBJMGIHILGB(LBJMGIHILGB other)
		: this()
	{
		eFGELJJFLKL_ = ((other.eFGELJJFLKL_ != null) ? other.eFGELJJFLKL_.Clone() : null);
		aNHGNLHNOKE_ = other.aNHGNLHNOKE_;
		iGLCEDBCKFH_ = ((other.iGLCEDBCKFH_ != null) ? other.iGLCEDBCKFH_.Clone() : null);
		bHDHIIBCDIJ_ = other.bHDHIIBCDIJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBJMGIHILGB Clone()
	{
		return new LBJMGIHILGB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LBJMGIHILGB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LBJMGIHILGB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EFGELJJFLKL, other.EFGELJJFLKL))
		{
			return false;
		}
		if (ANHGNLHNOKE != other.ANHGNLHNOKE)
		{
			return false;
		}
		if (!object.Equals(IGLCEDBCKFH, other.IGLCEDBCKFH))
		{
			return false;
		}
		if (BHDHIIBCDIJ != other.BHDHIIBCDIJ)
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
		if (eFGELJJFLKL_ != null)
		{
			num ^= EFGELJJFLKL.GetHashCode();
		}
		if (ANHGNLHNOKE != 0L)
		{
			num ^= ANHGNLHNOKE.GetHashCode();
		}
		if (iGLCEDBCKFH_ != null)
		{
			num ^= IGLCEDBCKFH.GetHashCode();
		}
		if (BHDHIIBCDIJ != 0)
		{
			num ^= BHDHIIBCDIJ.GetHashCode();
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
		if (eFGELJJFLKL_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EFGELJJFLKL);
		}
		if (ANHGNLHNOKE != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(ANHGNLHNOKE);
		}
		if (iGLCEDBCKFH_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(IGLCEDBCKFH);
		}
		if (BHDHIIBCDIJ != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(BHDHIIBCDIJ);
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
		if (eFGELJJFLKL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EFGELJJFLKL);
		}
		if (ANHGNLHNOKE != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ANHGNLHNOKE);
		}
		if (iGLCEDBCKFH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IGLCEDBCKFH);
		}
		if (BHDHIIBCDIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHDHIIBCDIJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LBJMGIHILGB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eFGELJJFLKL_ != null)
		{
			if (eFGELJJFLKL_ == null)
			{
				EFGELJJFLKL = new EFEGKDHEMFN();
			}
			EFGELJJFLKL.MergeFrom(other.EFGELJJFLKL);
		}
		if (other.ANHGNLHNOKE != 0L)
		{
			ANHGNLHNOKE = other.ANHGNLHNOKE;
		}
		if (other.iGLCEDBCKFH_ != null)
		{
			if (iGLCEDBCKFH_ == null)
			{
				IGLCEDBCKFH = new EFEGKDHEMFN();
			}
			IGLCEDBCKFH.MergeFrom(other.IGLCEDBCKFH);
		}
		if (other.BHDHIIBCDIJ != 0)
		{
			BHDHIIBCDIJ = other.BHDHIIBCDIJ;
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
			case 18u:
				if (eFGELJJFLKL_ == null)
				{
					EFGELJJFLKL = new EFEGKDHEMFN();
				}
				input.ReadMessage(EFGELJJFLKL);
				break;
			case 48u:
				ANHGNLHNOKE = input.ReadInt64();
				break;
			case 66u:
				if (iGLCEDBCKFH_ == null)
				{
					IGLCEDBCKFH = new EFEGKDHEMFN();
				}
				input.ReadMessage(IGLCEDBCKFH);
				break;
			case 88u:
				BHDHIIBCDIJ = input.ReadUInt32();
				break;
			}
		}
	}
}

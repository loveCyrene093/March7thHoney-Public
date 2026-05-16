using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateMovieRacingDataCsReq : IMessage<UpdateMovieRacingDataCsReq>, IMessage, IEquatable<UpdateMovieRacingDataCsReq>, IDeepCloneable<UpdateMovieRacingDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpdateMovieRacingDataCsReq> _parser = new MessageParser<UpdateMovieRacingDataCsReq>(() => new UpdateMovieRacingDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IMCEKFOOKHCFieldNumber = 14;

	private BNIGIAJOPGC iMCEKFOOKHC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateMovieRacingDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateMovieRacingDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNIGIAJOPGC IMCEKFOOKHC
	{
		get
		{
			return iMCEKFOOKHC_;
		}
		set
		{
			iMCEKFOOKHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMovieRacingDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMovieRacingDataCsReq(UpdateMovieRacingDataCsReq other)
		: this()
	{
		iMCEKFOOKHC_ = ((other.iMCEKFOOKHC_ != null) ? other.iMCEKFOOKHC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMovieRacingDataCsReq Clone()
	{
		return new UpdateMovieRacingDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateMovieRacingDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateMovieRacingDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IMCEKFOOKHC, other.IMCEKFOOKHC))
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
		if (iMCEKFOOKHC_ != null)
		{
			num ^= IMCEKFOOKHC.GetHashCode();
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
		if (iMCEKFOOKHC_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(IMCEKFOOKHC);
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
		if (iMCEKFOOKHC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMCEKFOOKHC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateMovieRacingDataCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iMCEKFOOKHC_ != null)
		{
			if (iMCEKFOOKHC_ == null)
			{
				IMCEKFOOKHC = new BNIGIAJOPGC();
			}
			IMCEKFOOKHC.MergeFrom(other.IMCEKFOOKHC);
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
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (iMCEKFOOKHC_ == null)
			{
				IMCEKFOOKHC = new BNIGIAJOPGC();
			}
			input.ReadMessage(IMCEKFOOKHC);
		}
	}
}
